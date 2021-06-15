using eShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
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


            // Identity Constants
            const string ADMIN_NAME = "admin";
            const string ADMIN_EMAIL = "danglegiavu@gmai.com";
            const string ADMIN_PASSWORD = "admin";
            const string ADMIN_GUID = "9B82C708-46FA-43ED-B71B-B2FFB02C2FF0";
            const string ROLE_GUID = "F27B1B87-4C47-4E18-849D-6EF168C68AD8";

            // Identity Data Seeding
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = new Guid(ROLE_GUID),
                Name = ADMIN_NAME,
                NormalizedName = ADMIN_NAME,
                Description = "Admin Role"
            });

            var hasher = new PasswordHasher<AppUser>();
 
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = new Guid(ADMIN_GUID),
                UserName = ADMIN_NAME,
                NormalizedUserName = ADMIN_NAME,
                Email = ADMIN_EMAIL,
                NormalizedEmail = ADMIN_EMAIL,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, ADMIN_PASSWORD),
                SecurityStamp = string.Empty,
                FirstName = "Vu",
                LastName = "Dang",
                Dob = new DateTime(2000, 02, 22)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = new Guid(ROLE_GUID),
                UserId = new Guid(ADMIN_GUID)
            });
        }
    }
}
