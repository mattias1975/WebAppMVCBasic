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


        public int SessionInfo_theNumber { get; private set; }
        public object theNumber { get; private set; }

        [HttpGet]

        public IActionResult Gues()

        {

            int theNumber = new Random().Next(1, 100);

            //save to session
            HttpContext.Session.SetInt32("theNumber", theNumber);

            //todo code


            return View();
        }
        [HttpPost]
        public IActionResult Gues(int Guesing)
        {
            if (HttpContext.Session.GetInt32("theNumber") != null)
            {
                int theNumber = (int)HttpContext.Session.GetInt32("theNumber");
                ViewBag.msg = WebbAppFirstCore.Models.Gues.Guesing(theNumber,Guesing);
            }
            else
            {
                return RedirectToAction("Gues");
            }
            //todo
            //HttpContext.Session.SetInt32("Guesing", Guesing);
            return View();
        }

        public IActionResult sledge()

        {
            return View();
        }
    }
}

