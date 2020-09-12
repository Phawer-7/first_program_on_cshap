using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, world\nInput random number:");
            // user 
            string lol = Console.ReadLine();
            // string to short
            short x = Convert.ToInt16(lol);
            // Write
            Console.Write("Okay!\n");
            
            // if and else
            if (x == 100)
            {
                Console.WriteLine("100");
            }
            else {
                Console.WriteLine("XZ");
            }

            // switch
            switch(x)
            {
                case 1:
                    Console.WriteLine("lolol");
                    break;
                case 10:
                    Console.WriteLine("Lol");
                    break;
                default:
                    Console.WriteLine("XZ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
