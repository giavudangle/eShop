using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {


        public static void DataSeeding(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "Home", Value = "Home Page" },
               new AppConfig() { Key = "Keyword", Value = "Keyword" },
               new AppConfig() { Key = "Description", Value = "Description" }
            );

            modelBuilder.Entity<Language>().HasData(
                    new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                    new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id=1,
                     ProductId=1,
                     Name = "Áo nam",
                     LanguageId = "vi-VN",
                     SeoAlias = "ao-nam",
                     SeoDescription = "Áo nam thời trang",
                     SeoTitle = "Áo nam",
                     Details = "Mô tả sản phẩm"
                 },
                new ProductTranslation()
                {
                    Id=2,
                    ProductId = 1,
                    Name = "Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "Men T Shirt",
                    SeoTitle = "T shirt",
                    Details = "Product Description"
                }
            );

            modelBuilder.Entity<ProductInCategory>().HasData(
                    new ProductInCategory()
                    {
                        CategoryId = 1,
                        ProductId = 1
                    }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product()
                    {
                        Id = 1,
                        DateCreated = DateTime.Now,
                        OriginalPrice = 200000,
                        Price = 300000,
                        Stock = 0,
                        ViewCount = 0,                  
                    }
                );
            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   Id = 1,
                   IsShowOnHome = true,
                   ParentId = null,
                   SortOrder = 1,
                   Status = Enums.Status.Active,
               },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Enums.Status.Active,
                }
           );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                 new CategoryTranslation()
                 {
                     Id = 1,
                     Name = "Áo nam",
                     LanguageId = "vi-VN",
                     SeoAlias = "ao-nam",
                     SeoDescription = "Áo thời trang nam",
                     SeoTitle = "Áo nam",
                     CategoryId=1,
                 },
                  new CategoryTranslation()
                  {
                      Id = 2,
                      Name = "Men T-Shirt",
                      LanguageId = "en-US",
                      SeoAlias = "men-shirt",
                      SeoDescription = "Ment T Shirt",
                      SeoTitle = "Men T Shirt",
                      CategoryId = 1
                  },
                  new CategoryTranslation()
                  {
                      Id = 3,
                      Name = "Áo nữ",
                      LanguageId = "vi-VN",
                      SeoAlias = "ao-nu",
                      SeoDescription = "Áo thời trang nữ",
                      SeoTitle = "Áo nữ",
                      CategoryId = 2
                  },
                new CategoryTranslation()
                {
                    Id=4,
                    Name = "Woman T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "woman-shirt",
                    SeoDescription = "Woman T Shirt",
                    SeoTitle = "Woman T Shirt",
                    CategoryId = 2
                }
                );   
        }
    }
}
