using eShop.AppService.Catalog.Products;
using eShop.AppService.Catalog.Products.Dtos;
using eShop.AppService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.AppService.Catalog
{
    class PulicProductService : IPublicProductService
    {
        public PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
