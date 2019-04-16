using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMVCBasic.Models;

namespace WebAppMVCBasic.Controllors
{
    public class PeopleController : Controller// innhav from controllerS
    {
        private readonly IPeopleService _peopleService;

        public Person IpeopleService { get; private set; }

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;

        }
        public IActionResult person(int id)
        {
            Person person = _peopleService.FindById(id);// fins person

            if (person == null)
            {                       //this if is if person is null return Notfound
                return NotFound();
            }
            return PartialView("_Name", person);// is it not null retern a PArtialView with person
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Person person = _peopleService.FindById(id);
            if (person == null)
            {
                return NotFound();          //this public Edit a person if person not= null
            }
            return PartialView("Edit", person);

        }
        [HttpGet]
        public IActionResult City(int id)
        {
            Person person = _peopleService.FindById(id);//Find city if person not null

            if (person == null)
            {
                return NotFound();//If person null this return this return NotFound
            }

            return PartialView("_City", person); //Return City in person
        }
        [HttpPost]
        public IActionResult Edit(Person person)  //this public edit a Person if person not null
        {
            if (person == null)
            {
                return NotFound(); //If person= null return NotFound
            }
            if (_peopleService.Update(person))//Update the person
            {
                return PartialView("_Person", person); //Return it to PartialView
            }
            else
            {
                return PartialView("Edit", _peopleService.FindById(person.Id));//If not found people Edit peorson
            }

        }
        [HttpPost]
        public IActionResult Create(string name, string city, string phone)
        {

            Person person = _peopleService.Create(name, city, phone);//Create new person

            if (person == null)// check of person=Null
            {
                return BadRequest(new { msg = "You most have a Value in every Inputs." });//if som post is null you get the message You must have a Value in every inputs
            }
            return PartialView("_person", person);//Return the person to PartialView

        }

        public IActionResult Delete(int id)// Delete people where id 
        {
            Person person = _peopleService.FindById(id); //Search Person by id
            if (person == null)//If Person=Null
            {
                return NotFound();//returnerar Notfound om person är null alltså tom
            }
            _peopleService.Delete(id);//else if id not null Delete person whith what id
            return Content(" ");
        }
        public IActionResult Filter(string filter)//Do IAction Filter
        {
      
                if (string.IsNullOrWhiteSpace(filter))//If string is null or where is a space
                {
                    return PartialView("_List", _peopleService.GetPeople());// do s List of person and contains tolower
                }

                filter = filter.ToLower();//Do filter to a tolower where Name.Tolower Contains the filter (what you Search the filter is here line under)

                return PartialView("_List", _peopleService.GetPeople()//Return a PartialView with People
                    .Where(p => p.Name.ToLower().Contains(filter) || p.City.ToLower().Contains(filter))
                    .ToList());
                   
        }
    }
}