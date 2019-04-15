﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPeople.Models;

namespace WebAppMVCBasic.Modells
{
    public class DbPerson
    {
        public static void initialize(PeopleDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.Poeples.Any())
            {
                return;
            }
            else
            {
                context.Poeples.Add(new Person("Mattias", "Rävemåla", "0735 - 124338"));
                context.SaveChanges();


        } 
}
        }
    }
                
    
