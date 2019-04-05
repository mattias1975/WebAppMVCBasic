using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

            return View();//new
        }
        public const string SessiontheNumber = "_theNumber";
        

        public int SessionInfo_theNumber{ get; private set; }
        public object theNumber { get; private set; }

        [HttpGet]
      
        public IActionResult Gues()
            
        {
            
            int theNumber = new Random().Next(1, 100);

            //save to session
            //todo code
            int? Number = theNumber;
            Number = HttpContext.Session.GetInt32("_Number");
            ViewBag.Number =Number;
            return View();
        }
        [HttpPost]
        public IActionResult Gues(int Guesing)
        {
            //todo
            HttpContext.Session.SetInt32("Number", Guesing);
            return View("index",Guesing);
        }

        public IActionResult sledge()

        {
            return View();
        }
    }
}
      
