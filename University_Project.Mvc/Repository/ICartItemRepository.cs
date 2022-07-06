using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Repository
{
    public interface ICartItemRepository
    {
        void AddCartItem(CartItem cartItem);

        void DeleteCartItem(int Id);

        List<CartItem> GetCartItems();
    }
}
