using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Models.Product product = new Models.Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "А boat for one person",
                Category = "Watersports",
                Price = 275M
            };
            return View(product);
        }
    }
}