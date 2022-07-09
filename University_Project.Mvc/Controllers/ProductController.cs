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
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index(Product product) 
        {
            return View(product);
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
            else return _productService.GetProductById(id);
        }

        [HttpPost("Create")]
        public ActionResult CreateProduct(Product product)
        {
            _productService.CreateProduct(product);
            return Ok("Product created");
        }

        [HttpPatch("Update/{id}")]
        public IActionResult UpdateProduct(Product product, int id)
        {
            _productService.UpdateProductById(product, id);
            return Ok("Prodcut updated");
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProductById(id);
            return Ok("Product deleted");
        }
    }
}