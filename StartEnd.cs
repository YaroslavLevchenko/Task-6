using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
     class StartEnd
    {
        private int start = 1;
        private int end = 100;
        public void ReadNumber()
        {

            int[] allNumbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    allNumbers[i] = int.Parse(Console.ReadLine());
                    if (allNumbers[i] < start || allNumbers[i] > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format of input!");
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number is out of the range!");
                    break;
                }
                start = allNumbers[i];
            }
        }
    }
}
