using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNum
{
    using System;

    class Number
    {

        
        static double HarmonicNum(int N)
        {
            
            float harmonic = 1;

            for (int i = 2; i <= N; i++)
            {
                harmonic += (float)1 / i;
            }

            return harmonic;
        }

        static public void Main()
        {
            int N = 4;

            Console.Write(HarmonicNum(N));
            Console.ReadKey();
        }
    }

}