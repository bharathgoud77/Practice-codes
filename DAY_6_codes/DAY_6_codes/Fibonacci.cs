using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_6_codes
{
    public class Fibonacci
    {
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        // driver code
        public static void Main(string[] args)
        {
            int n = 9;
            Console.Write(Fib(n));
            Console.ReadKey();
        }
    }
    }
