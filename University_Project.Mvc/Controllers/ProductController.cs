using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
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

        [Authorize(Roles = "Member")]
        [Route("productPage")]
        public ActionResult Index(int id) 
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [Authorize (Roles = "Admin")]
        [Route("ProductAddPage")]
        public ActionResult ProductAddPage()
        {
            return View();
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

        [HttpPost]
        public IActionResult CreateProduct([FromForm] ProductFormViewModel product)
        {

            if (ModelState.IsValid)
            {
                var ms = new MemoryStream();
                product.Image.CopyTo(ms);
                var picture = ms.ToArray();
                var model = new Product() { Id = 0, Description = product.Description, Image = picture, Name = product.Name, Price = product.price, Category_Id = product.Category_Id };
                _productService.CreateProduct(model);
                return RedirectToAction("ProductsList", "Home");
            }
            return View(product);
        }

        [HttpPatch("Update/{id}")]
        public IActionResult UpdateProduct(Product product, int id)
        {
            _productService.UpdateProductById(product, id);
            return Ok("Prodcut updated");
        }

        
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProductById(id);
            return RedirectToAction("ProductsList", "Home");
        }
    }
}