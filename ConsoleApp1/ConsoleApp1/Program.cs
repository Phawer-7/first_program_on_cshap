using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, world\nHow are you?");
            // user 
            string lol = Console.ReadLine();
            // string to short
            short x = Convert.ToInt16(lol);
            // Write
            Console.Write("Okay!\n");
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
