using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
     class Dividing
    {
        double a, b;
        public double A
        {
            get => a;
            set => a = value;
        }
        public double B
        {
            get => b;
            set => b = value;
        }

        public void Initialization()
        {
            try
            {
                Console.WriteLine("Type a: ");
                A = double.Parse(Console.ReadLine());
                Console.WriteLine("Type b: ");
                B = double.Parse(Console.ReadLine());
                if (b == 0) { throw new DivideByZeroException(); }
                if(a < b) { throw new ApplicationException("a should be > b"); }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Div()
        {
            double c = 0;
            c = a / b;
            Console.WriteLine("a / b = " + $"{c}");
        }
     
    }
}
