using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace WebbAppFirstCore.Models
{
    public class Gues
    {
        public static string Guesing(int thenumber, int Guesing)
        {

            string answer;
           
            if (Guesing != thenumber)
            {
                int number=0;
                number++;
                answer = "Wrong answer";
                if (Guesing < thenumber)
                {
                    answer = "Wrong answer gues to low";
                }
                if (Guesing > thenumber)
                {
                    answer = "Wrong answer gues to high";
                }
            }
          
            else
            {
                answer = "Congratulation what number is it";
                if(Guesing<thenumber)
                {

                }
            }

            return answer;

        }
    }
}
