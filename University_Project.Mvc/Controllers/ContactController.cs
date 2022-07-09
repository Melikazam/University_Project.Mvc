using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using University_Project.Mvc.Models;
using University_Project.Mvc.Services;

namespace University_Project.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : Controller {

        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("Create")]
        public ActionResult CreateContact([FromForm] Contact contact)
        {
            _contactService.CreateContact(contact);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("Get")]
        public ActionResult<List<Contact>> GetContacts()
        {
            if (_contactService.GetContacts() == null) return NotFound("Contact not found.");
            else return _contactService.GetContacts();
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteContact(int id)
        {
            _contactService.DeleteContactById(id);
            return Ok("Contact deleted");
        }
    }
}
