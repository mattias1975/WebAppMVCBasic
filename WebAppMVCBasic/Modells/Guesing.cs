﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace WebbAppFirstCore.Models
{
    public class Guesing
    {
        public static string Gues(int answer)
        {
            string you;
            you = "";
            int yanswer;
            string text = "";
            int antal = 0;
            yanswer = Int32.Parse(you);
            bool check = true;


            if (check == true)
            {
                Random random = new Random();
                answer = random.Next(1, 100);
                check = false;

            }
            antal++;
            if (yanswer == answer)
            {
                text = "whats rignt you did on " + (antal) + "guesing";
                check = true;

            }
            else
            {


                text = "whats wrong gues again";
            }

            return text;
        }
    }
}
