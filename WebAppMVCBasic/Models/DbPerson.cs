using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCBasic.Models;

namespace WebAppMVCBasic.Modells
{
    public class DbPerson
    {
        public static void initialize(PeopleDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.People.Any())
            {
                return;
            }
            else
            {
                context.People.Add(new Person("Mattias", "Rävemåla", "Malmö"));
                context.SaveChanges();


            }
        }
    }
}


