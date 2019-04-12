using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;
using WebAppPeople.Models;

namespace WebAppMVCBasic
{
    public class PeopleController : Controller
    {
        public IActionResult Person()
        {
            return View(new Person() { Name= "Kent", City="Osby", Birthcity="Växjö", Id=1});
 
        }
    }
}
