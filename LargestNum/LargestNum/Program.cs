using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNum
{ 
    class program
{
    static void Main(string[] args)
    {
        int num1, num2, num3;
        // set the value of the three numbers
        num1 = 15;
        num2 = 10;
        num3 = 30;
        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.Write("Number one is the largest!\n");
            }
            else
            {
                Console.Write("Number three is the largest!\n");
            }
        }
        else if (num2 > num3)
            Console.Write("Number two is the largest!\n");
        else
            Console.Write("Number three is the largest!\n");
        Console.ReadKey();
    }
}
}