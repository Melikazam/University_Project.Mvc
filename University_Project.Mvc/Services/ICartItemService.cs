using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Services
{
    public interface ICartItemService
    {
        void CreateCartItem(CartItem cartItem);
        List<CartItem> GetCartItems();
        void DeleteCartItemById(int id);
    }
}