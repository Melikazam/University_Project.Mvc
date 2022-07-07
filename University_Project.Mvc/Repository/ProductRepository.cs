using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(u => u.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void UpdateProduct(Product product, int id)
        {
            Product temp = _context.Products.FirstOrDefault(u => u.Id == id);
            if (temp != null) {
                temp.Name = product.Name;
                temp.Price = product.Price;
                temp.Description = product.Description;
                temp.Image = product.Image;
                temp.Category_Id = product.Category_Id;
            }
            _context.SaveChanges();
        }
    }
}
