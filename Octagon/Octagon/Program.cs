using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Octagon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int Octagon;

            Console.WriteLine("How long is one side of the octogon?");
            Octagon = int.Parse(Console.ReadLine());

            a = Math.Pow(2);
            Console.WriteLine("The area of the octogon is {0}", a);
        }
    }
}
