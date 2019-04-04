using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebbAppFirstCore.Models;

namespace WebAppMVCBasic
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Kontakt()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Fever()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Fever(int temprature)
        {
      
            ViewBag.msg = Temperature.FeverChecker(temprature, "");
            
            return View();
        }

        public IActionResult sledge()

        {
            return View();
        }
    }
}
      
