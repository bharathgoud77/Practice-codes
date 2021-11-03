using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgramme
{
    class program
{
    public static int highestPowerof2(int n)
    {
        int res = 0;
        for (int i = n; i >= 1; i--)
        {
            // If i is a power of 2
            if ((i & (i - 1)) == 0)
            {
                res = i;
                break;
            }
        }
        return res;
    }

    
    static public void Main()
    {
        int n = 10;
        Console.WriteLine(highestPowerof2(n));
    }
}

