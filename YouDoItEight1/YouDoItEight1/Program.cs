using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace YouDoItEight1
{
    class Program
    {
        static void Main(string[] args)
        {int first = 34, second = 712;
            Write("Before you swap first is {0}", first);
            WriteLine(" and second is {0}", second);
            double Swap(ref first, ref second);
            Write("After swap first is {0}", first);
            WriteLine(" and second is {0}", second);

           
        }
        private static double Swap(ref int one, ref int two)
        {
            int temp;
            temp = one;
            one = two;
            two = temp;
        }
    }
}
