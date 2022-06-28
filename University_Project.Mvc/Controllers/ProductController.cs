using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using University_Project.Mvc.Models;
using University_Project.Mvc.Services;

namespace University_Project.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ProductServices _productService;
        public ProductController(ProductServices productService, IMapper mapper)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet("Get")]
        public ActionResult<List<Product>> GetProducts()
        {
            if (_productService.GetProducts() == null) return NotFound("Product not found.");
            else return Ok("Products found");
        }

        [HttpGet("Get/{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            if (_productService.GetProductById(id) == null) return NotFound("Product not found.");
            else return Ok("Product found");
        }

        [HttpPost("Create")]
        public ActionResult CreateProduct(string Name, float Price, string Description, string Image, int Rating_ID, string Category)
        {
            _productService.CreateProduct(Name, Price, Description, Image, Rating_ID, Category);
            return Ok("Product created");
        }

        [HttpPut("Update")]
        public IActionResult UpdateProduct(string Name, float Price, string Description, string Image, int Rating_ID, string Category)
        {
            _productService.UpdateProductById(Name, Price, Description, Image, Rating_ID, Category);
            return Ok("Prodcut updated");
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProductById(id);
            return Ok("Product deleted");
        }
    }
}