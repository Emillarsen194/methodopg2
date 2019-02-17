using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg2
{
    class logic
    {


        public static double Pythagoras(double numberA, double numberB) //phytagoras method
        {


            numberA = Math.Pow(numberA, 2); // taking number a and b and multiplys it with it self
            numberB = Math.Pow(numberB, 2); //

            double sum = numberA + numberB; // getting the sum of the numbers plussed together
            sum = Math.Pow(sum, 2); // getting the final result

            // should not be here a part of gui but cant return two things
            string t = WhichIsBigger(numberA, numberB);
            Console.WriteLine(t);


            return sum; //returing sum 

        }

        public static string WhichIsBigger(double numberA, double numberB)
        {
            
            if (numberA > numberB) // finding out which number is greater
            {
                return numberA + " er større end " + numberB;
            }

            else if (numberB > numberA)
            {
                return numberB + " er større end " + numberA;
                
            }

            else
            {
                return numberB + " er samme størrelse som " + numberA;
            }

        }
         
       

    }
}
