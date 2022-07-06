using System.Collections.Generic;
using University_Project.Mvc.Models;
using University_Project.Mvc.Repository;

namespace University_Project.Mvc.Services
{
    public class CartItemService : ICartItemService
    {
        private readonly ICartItemRepository _cartItemRepository;
        public CartItemService(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }
        public void CreateCartItem(CartItem cartItem)
        {
            _cartItemRepository.AddCartItem (cartItem);
        }

        public void DeleteCartItemById(int id)
        {
            _cartItemRepository.DeleteCartItem(id);
        }

        public List<CartItem> GetCartItems()
        {
            return _cartItemRepository.GetCartItems();
        }
    }
}
