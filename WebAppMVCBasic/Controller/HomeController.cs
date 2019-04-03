using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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


        public IActionResult sledge()

        {
            return View();
            }
        }
}