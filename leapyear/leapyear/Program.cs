using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    using System;

    class Year
    {

        static bool checkYear(int year)
        {
            
           
            if (year % 400 == 0)
                return true;

            // Else If a year is multiple of 100,
            // then it is not a leap year
            if (year % 100 == 0)
                return false;

            // Else If a year is multiple of 4,
            // then it is a leap year
            if (year % 4 == 0)
                return true;
            return false;
        }

        // Driver method
        public static void Main()
        {
            
            Console.WriteLine("Enter the 4 digit number");
            int input = int.Parse(Console.ReadLine());
            Console.Write(checkYear(input) ? "Leap Year" : "Not a Leap Year");
            Console.ReadKey();
        }

    }
}