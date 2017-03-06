using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugFour3
{
    class Program
    {
        static void Main(string[] args)
        {
            int credits, year;
            string inputString;
            double tuition;
            const int LOWCREDITS = 12;
            const int HIGHCREDITS = 18;
            const double HOURFEE = 150.00;
            const double DISCOUNT = 0.15;
            const double FLAT = 1900.00;
            const double RATE = 100.00;
            const int SENIORYEAR = 4;
            WriteLine("How many credits? ");
            inputString = ReadLine();
            credits = Convert.ToInt32(inputString);
            WriteLine("Year in school? ");
            inputString = ReadLine();
            year = Convert.ToInt32(inputString);
            if (credits <= LOWCREDITS)
                tuition = HOURFEE * credits;
            else
               if (LOWCREDITS < credits && credits <= HIGHCREDITS)
                tuition = FLAT;
            else
                tuition = FLAT + (credits - HIGHCREDITS) * RATE;

            if (year == SENIORYEAR)
                tuition = tuition - (tuition * DISCOUNT);

            WriteLine("For year {0}, with {1} credits",
               year, credits);
            WriteLine("Tuition is {0}", tuition.ToString("C"));
        }
    }
}
