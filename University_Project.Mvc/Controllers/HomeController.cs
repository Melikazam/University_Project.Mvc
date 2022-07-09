using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using University_Project.Mvc.Models;
using University_Project.Mvc.Services;

namespace University_Project.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _service;

        public HomeController(IProductService service, ILogger<HomeController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [Authorize()]
        [Authorize(Roles = "Member")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        //[Authorize(Roles = "Member")]
        [Route("Catalog")]
        public IActionResult Catalog()
        {
            return View(_service.GetProducts());
        }

        //[Authorize(Roles = "Member")]
        [Route("ContactUs")]
        public IActionResult ContactUs()
        {
            return View();
        }

        //[Authorize(Roles = "Member")]
        [Route("AboutUs")]
        public IActionResult AboutUs()
        {
            return View();
        }

        //[Authorize(Roles = "Admin")]
        [Route("ProductsList")]
        public IActionResult ProductsList()
        {
            return View(_service.GetProducts());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
