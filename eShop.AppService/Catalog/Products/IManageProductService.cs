
using eShop.ViewModels.Catalog.Products;
using eShop.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
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
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        // Do this later
        //Task<int> AddImages(int productId, List<IFormFile> files);
        //Task<int> RemoveImage(int imageId);
        //Task<int> UpdateImage(int imageId, string caption, bool isDefault);
        //Task<List<ProductImageViewModel>> GetListImages(int productId);

    }
}
