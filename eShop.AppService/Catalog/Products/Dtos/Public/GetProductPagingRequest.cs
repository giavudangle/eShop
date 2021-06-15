using eShop.AppService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.AppService.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }



    }


}
