using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{

     class Program
    {
        static void Main(string[] args)
        {
            
            NumberOfExceptions numberOfExceptions = new NumberOfExceptions();
            numberOfExceptions.Initialization();
            numberOfExceptions.Div();

            Dividing dividing = new Dividing();
            dividing.Initialization();
            dividing.Div();

            StartEnd startEnd = new StartEnd();
            startEnd.ReadNumber();

            Console.ReadKey();
        }
    }
}
