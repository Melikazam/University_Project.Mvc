using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void UpdateProductById(string name, float price, string description, string image, string category);
        void DeleteProductById(int id);
    }
}
