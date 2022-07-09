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


        public IActionResult Index()
        {
            if(User.IsInRole("Admin"))
                return RedirectToAction("ProductsList");
            return View();
        }

        //[Authorize(Roles = "Member")]
        [Route("Catalog")]
        public IActionResult Catalog(string name, int? feature, int? category)
        {
            if (String.IsNullOrEmpty(name) && !feature.HasValue && !category.HasValue) { return View(_service.GetProducts()); }
            else if (feature.HasValue && feature.Value == 1) { return View(_service.GetProducts().OrderBy(x => x.Price).ToList()); }
            else if (feature.HasValue && feature.Value == 2) { return View(_service.GetProducts().OrderByDescending(x => x.Price).ToList()); }
            else if (category.HasValue && category.Value == 1) { return View(_service.GetProducts().Where(x => x.Category_Id == category.Value).ToList()); }
            else if (category.HasValue && category.Value == 2) { return View(_service.GetProducts().Where(x => x.Category_Id == category.Value).ToList()); }
            var lst = _service.GetProducts().Where(p => p.Name.ToLower().StartsWith(name.ToLower())).ToList();
            return View(lst);
        }

        [Authorize(Roles = "Member")]
        public IActionResult ContactUs()
        {
            return View();
        }

        //[Authorize(Roles = "Member")]
        public IActionResult AboutUs()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
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
