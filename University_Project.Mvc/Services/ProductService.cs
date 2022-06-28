using System;
using System.Collections.Generic;
using University_Project.Mvc.Models;
using University_Project.Mvc.Repository;

namespace University_Project.Mvc.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        
        public ProductService(IProductRepository repository)
        {
            _productRepository = repository;
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProduct(id);
        }

        public void CreateProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public void UpdateProductById(string Name, float Price, string Description, string Image, string Category)
        {
               
        }

        public void DeleteProductById(int id)
        {
            _productRepository.DeleteProduct(GetProductById(id));
        }
    }
}
