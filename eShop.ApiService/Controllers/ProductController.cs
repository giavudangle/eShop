using eShop.AppService.Catalog.Products;
using eShop.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById(int productId,string languageId)
        {
            if (String.IsNullOrEmpty(languageId)) languageId = "vn-VN";
            var products = await _productService.GetById(productId, languageId);
            if (products == null)
                return BadRequest("Occured when trying to get");
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            var productId = await _productService.Create(request);
            if (productId == 0)
                return BadRequest();
            var product = await _productService.GetById(productId, request.LanguageId);
            return CreatedAtAction(nameof(GetById),new { id = productId},product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ProductUpdateRequest request)
        {
            var affected = await _productService.Update(request);
            if (affected == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affected = await _productService.Delete(productId);
            if (affected == 0)
                return BadRequest();
            return Ok();
        }

        [HttpPut("price/{id}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int id,decimal newPrice)
        {
            var affected = await _productService.UpdatePrice(id,newPrice);
            if (!affected)
                return BadRequest();
            return Ok();
        }

    }
}