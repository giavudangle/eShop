using eShop.AppService.Catalog.Products.Dtos;
using eShop.AppService.Catalog.Products.Dtos.Manage;
using eShop.AppService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.AppService.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task AddViewCount(int productId);
        Task<bool> UpdateStock(int productId, int quantity);
        Task<int> Delete(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
