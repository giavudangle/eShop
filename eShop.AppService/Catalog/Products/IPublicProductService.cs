using eShop.AppService.Catalog.Products.Dtos;
using eShop.AppService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.AppService.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedViewModel<ProductViewModel>> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
