using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                Console.WriteLine(a + b);
            }
            else
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = a + b;
                Console.WriteLine(c);
            }
        }
    }
}
