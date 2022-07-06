using System.Collections.Generic;
using System.Linq;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Repository
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly AppDbContext _context;

        public CartItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddCartItem(CartItem cartItem)
        {
            _context.CartItems.Add(cartItem);
            _context.SaveChanges();
        }

        public void DeleteCartItem(int id)
        {
            _context.CartItems.Remove(_context.CartItems.FirstOrDefault(u => u.Id == id));
            _context.SaveChanges();
        }

        public List<CartItem> GetCartItems()
        {
            return _context.CartItems.Select(u => u).ToList();
        }
    }
}
