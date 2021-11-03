using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter The Numbers");
        int i = int.Parse(Console.ReadLine());
        int rev = 0;
        while (i > 0)
        {
            int j = i % 10;
            rev = (rev * 10) + j;
            i = i / 10;
        }
        Console.WriteLine("reverse number is:" + rev);
        Console.ReadKey();
    }
}

