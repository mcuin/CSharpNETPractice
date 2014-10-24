using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static int Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("You entered the following {0} command line arguments:", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}", args[i]);
            }

            return 0;
        }
    }
}
