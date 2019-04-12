using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPeople.Models
{
    public interface IPeopleService
    {
        Person Create(string name, string city, string birthcity);
        Person FindById(int id);
        List<Person> GetPeople();
        bool Update(Person people);
        bool Delete(int id);
    }
}