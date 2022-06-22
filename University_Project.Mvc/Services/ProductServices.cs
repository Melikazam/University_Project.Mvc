using AutoMapper;
using System;
using System.Collections.Generic;
using University_Project.Mvc.Models;
using University_Project.Mvc.Repository;

namespace University_Project.Mvc.Services
{
    public class ProductServices
    {
        private readonly ProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductServices(ProductRepository repository, IMapper mapper)
        {
            _productRepository = repository;
            _mapper = mapper;
        }

        public List<Product> GetProducts()
        {
            return _mapper.Map<List<Product>>(_productRepository.GetProducts());
        }

        public Product GetProductById(int id)
        {
            return _mapper.Map<Product>(_productRepository.GetProduct(id));
        }

        public void CreateProduct(string Name, float Price, string Description, string Image, int Rating_ID, string Category)
        {
            _productRepository.AddProduct(_mapper.Map<Product>(new Product(0, Name, Price, Description, Image, Rating_ID, Category)));
        }

        public void UpdateProductById(string Name, float Price, string Description, string Image, int Rating_ID, string Category)
        {
               
        }

        public void DeleteProductById(int id)
        {
            _productRepository.DeleteProduct(_mapper.Map<Product>(GetProductById(id)));
        }
    }
}
