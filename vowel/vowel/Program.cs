using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel
{
    class Program
    
 

        {
            
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a Alphabet");
                char cha = Convert.ToChar(Console.ReadLine().ToLower());
                switch (cha)
                {
                    case 'a':
                        Console.WriteLine("It is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("It is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("It is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("It is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("It is vowel");
                        break;
                    default:
                        Console.WriteLine("It Is Not Vowel");
                        break;
                }
                Console.ReadKey();
            }
        }
    } 