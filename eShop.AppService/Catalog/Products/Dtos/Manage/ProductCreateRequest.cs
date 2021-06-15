﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.AppService.Catalog.Products.Dtos.Manage
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }

        public string LanguageId { set; get; }

        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }

    }
}
