﻿using Microsoft.AspNetCore.Mvc;
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

        public ActionResult Index() 
        {
            return View();
        }

        [HttpGet("Get")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _productService.GetProducts();
        }

        [HttpGet("Get/{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            if (_productService.GetProductById(id) == null) return NotFound("Product not found.");
            else return Ok("Product found");
        }

        [HttpPost("Create")]
        public ActionResult CreateProduct(Product product)
        {
            _productService.CreateProduct(product);
            return Ok("Product created");
        }

        [HttpPut("Update")]
        public IActionResult UpdateProduct(string name, float price, string description, string image, string category)
        {
            _productService.UpdateProductById(name, price, description, image, category);
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