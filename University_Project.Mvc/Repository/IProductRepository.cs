using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);

        void DeleteProduct(Product product);

        Product GetProduct(int id);

        List<Product> GetProducts();

        void UpdateProduct(Product product);
    }
}
