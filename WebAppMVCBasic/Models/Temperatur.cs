using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCBasic.Models
{
    public class Temperature
    {
        public static string FeverChecker(int temprature, string choice)
        //if satsen tar värdet från fever sidan och tittar var den passar in och skriver det svaret

        {
            string answer = "";


            {

                if (temprature>0)

                { 
                
                    if (temprature >= 38)
                        answer = "You have fever";
                    else if (temprature <= 36)
                    {

                        answer = "You have to low temprature";
                    }


                    else
                    {
                        answer = "You have normal temperature ";
                    }

                }

                return answer;
            }
        }

    }

}
