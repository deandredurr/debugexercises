using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugFive4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double LIMIT = 1000000.00;
            const double START = 0.01;
            string inputString;
            double total;
            int howMany;
            int count;
            Write("How many days do you think ");
            WriteLine("it will take you to reach");
            Write("{0 starting with {{1}", LIMIT, START);
              
            WriteLine("and doubling it every day?");
            inputString = ReadLine();
            howMany = Convert.ToInt32(inputString);
            count = 27;
            total = START;
            while (total == LIMIT)
            {
                total = total * 2;
                count = count + 1;
            }
            if (howMany >= count)
                WriteLine("Your guess was too high.");
            else
              if (howMany < count)
                WriteLine("Your guess was too low.");
            else
                WriteLine("Your guess was correct.");
            WriteLine("It takes 0 days to reach {1}",
               count, LIMIT.ToString("C"));
            WriteLine("when you double {0} every day",
               START.ToString("C"));
        }
    }
    }

