using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{

    public class PrimeNumberExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter input number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if ((num % i) == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("the number is a prime number");
            }
            else
            {
                Console.WriteLine("the number is a not prime number");
                Console.ReadKey();
            }
        }
    }
}
