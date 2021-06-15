using eShop.AppService.Catalog.Products.Dtos;
using eShop.AppService.Catalog.Products.Dtos.Manage;
using eShop.AppService.Dtos;
using eShop.Data.EF;
using eShop.Data.Entities;
using eShop.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.AppService.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly EShopDBContext _context;
        public ManageProductService(EShopDBContext context)
        {
            _context = context;
        }

        public async Task AddViewCount(int productId)
        {
            Product product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            Product product = new Product()
            {
                Price = request.Price,
                OriginalPrice  = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductTranslations  = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.SeoDescription,
                        SeoAlias = request.SeoAlias,
                        SeoTitle = request.SeoTitle,
                        SeoDescription = request.SeoDescription,
                        LanguageId = request.LanguageId
                    }
                }
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            Product product = await _context.Products.FindAsync(productId);
            if (product == null) throw new EShopException($"Cannot find product with id : {productId}");
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {

            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pt, pic };

            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.pt.Name.Contains(request.Keyword));
            if(request.CategoryIds.Count > 0)
            {
                query = query.Where(x => request.CategoryIds.Contains(x.pic.CategoryId));
            }
            int totalRecord = await query.CountAsync();
            var data = await query
                .Skip(request.PageIndex - 1)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    Price = x.p.Price,
                    OriginalPrice = x.p.OriginalPrice,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount
                }).ToListAsync();
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRecord,
                Items = data
            };
            return pagedResult;
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            var productTranslations = _context.ProductTranslations
                .FirstOrDefault(x => x.ProductId == request.Id 
                && x.LanguageId == request.LanguageId);
            if (product == null || productTranslations == null) 
                throw new EShopException($"Cannot find product with given id : {request.Id}");
            productTranslations.Name = request.Name;
            productTranslations.SeoAlias = request.SeoAlias;
            productTranslations.SeoDescription = request.SeoDescription;
            productTranslations.Description = request.Description;
            productTranslations.Details = request.Details;
            return await _context.SaveChangesAsync();

        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            Product product = await _context.Products.FindAsync(productId);
            if (product == null) throw new EShopException($"Cannot find product with given id : {productId}");
            product.Price = newPrice;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateStock(int productId, int quantity)
        {
            Product product = await _context.Products.FindAsync(productId);
            if (product == null) throw new EShopException($"Cannot find product with given id : {productId}");
            product.Stock += quantity;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
