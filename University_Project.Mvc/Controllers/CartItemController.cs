using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using University_Project.Mvc.Models;
using University_Project.Mvc.Services;

namespace University_Project.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : Controller
    {
        private readonly ICartItemService _cartItemService;
        public CartItemController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("Create")]
        public ActionResult CreateCartItem(CartItem cartItem)
        {
            _cartItemService.CreateCartItem(cartItem);
            return Ok("Contact created");
        }

        [HttpGet("Get")]
        public ActionResult<List<CartItem>> GetCartItems()
        {
            if (_cartItemService.GetCartItems() == null) return NotFound("Contact not found.");
            else return _cartItemService.GetCartItems();
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteGetCartItem(int id)
        {
            _cartItemService.DeleteCartItemById(id);
            return Ok("Contact deleted");
        }
        
    }
}
