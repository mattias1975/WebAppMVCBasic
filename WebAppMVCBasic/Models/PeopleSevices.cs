using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCBasic.Models;

namespace WebAppMVCBasic.Models
{
    public class PeopleService : IPeopleService
    {
        private PeopleDBContext _context;

        public PeopleService(PeopleDBContext context)
        {
            _context = context;
        }

        public Person Create(string name, string city, string birthcity)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(birthcity))
            {
                return null;
            }
            Person person = new Person(name, city, birthcity);
            _context.Add(person);
            _context.SaveChanges();
            return person;
        }

        public bool Delete(int id)
        {

            Person person = _context.Poeples.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                return false;
            }

            _context.Poeples.Remove(person);
            _context.SaveChanges();

            return true;
        }

        public Person FindById(int id)
        {
            return _context.Poeples.FirstOrDefault(p => p.Id == id);
        }

        public List<Person> GetPeople()
        {
            return _context.Poeples.ToList();
        }

        public bool Update(Person person)
        {
            Person original = _context.Poeples.FirstOrDefault(p => p.Id == person.Id);

            if (original == null)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.Name)
                || string.IsNullOrWhiteSpace(person.City)
                || string.IsNullOrWhiteSpace(person.Birthcity))
            {
                return false;
            }

            original.Name = person.Name;
            original.City = person.City;
            original.Birthcity = person.Birthcity;

            _context.SaveChanges();

            return true;
        }
    }
}
