using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new ProductRepository().GetProducts.Where(p => p.Price > 500M));
        }
    }
}