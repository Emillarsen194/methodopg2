using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg2
{
    class gui
    {
        static void Main(string[] args)
        {
           
            Console.Write("Indtast tal A: ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Indtast tal B: ");
            double numberB = double.Parse(Console.ReadLine());

           
            Console.WriteLine("Pytagoras = " + logic.Pythagoras(numberA, numberB)); // printing our method
 
         
        }
    }
}
