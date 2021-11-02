using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotient
{
    class program
    {
        public int N, Divisor, Quotient, Remainder;

        public void compute()
        {
            Console.WriteLine("Enter the number you want to divide");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the divisor");
            Divisor = Convert.ToInt32(Console.ReadLine());
            Quotient = N / Divisor;
            Remainder = N % Divisor;

            Console.WriteLine("Quotient is: " + Quotient);
            Console.WriteLine("Remainder is: " + Remainder);
        }
    }

}