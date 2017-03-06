using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugFive3
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            int number;
            const int LOW = 0;
            const int HIGH = 99;
            const int NUMINROW = 20;
            for (letter = 'A'; letter <'Z'; ++letter)
                for(number = LOW; number < HIGH; ++number)
            {
                    if ( 0 < NUMINROW)
                        WriteLine();
                    WriteLine("{0}{1}", letter, number);
                    
            }
            ReadKey();
        }
    }
}
