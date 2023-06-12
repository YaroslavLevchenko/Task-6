using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class NumberOfExceptions
    {
        int numberOne, numberTwo;

        public int NumberOne
        {
            get => numberOne; set => numberOne = value;
        }

        public int NumberTwo
        {
            get => numberTwo; set => numberTwo = value;
        }

        public void Initialization()
        {
            try
            {
                Console.WriteLine("Type the first number: ");
                NumberOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the second number: ");
                NumberTwo = int.Parse(Console.ReadLine());
            }
            catch (DivideByZeroException ex) { Console.WriteLine(ex.Message); }
            catch (FormatException ex) { Console.WriteLine(ex.Message); }
            catch(OverflowException ex) { Console.WriteLine(ex.Message); }
        }

        public void Div()
        {
            int c = numberOne + numberTwo;
            Console.WriteLine("The result is: " + $"{c}");
        }
    }
}
