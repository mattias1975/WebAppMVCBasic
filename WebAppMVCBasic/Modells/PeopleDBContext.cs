﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPeople.Models;

namespace WebAppMVCBasic.Modells
{
    public class PeopleDBContext : DbContext
    {
   public PeopleDBContext(DbContextOptions<PeopleDBContext> options) : base(options) { }
   public DbSet<Person> Poeples { get; set; }
        public object Persons { get; internal set; }
    }
        }


