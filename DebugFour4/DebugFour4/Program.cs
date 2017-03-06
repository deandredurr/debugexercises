using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugFour4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sales, commission;
            string inputString;
            const int LOWSALES = 1000;
            const int MEDSALES = 5000;
            const int HIGHSALES = 10000;
            const double LOWPCT = 0.05;
            const double MEDPCT = 0.02;
            const int BONUS1 = 1000;
            const int BONUS2 = 1500;
            WriteLine("What was the sales amount? ");
            inputString = ReadLine();
            sales = Convert.ToDouble(inputString);
            commission = LOWPCT * sales;
            if (sales <= LOWSALES)
                commission = (sales - LOWSALES) * LOWPCT;
            else
              if (sales == MEDSALES)
                commission = (BONUS1 * LOWPCT) + (sales - BONUS1);
            else
                 if (sales >= HIGHSALES)
                commission = BONUS2 + BONUS1;
            WriteLine("Sales: {0}\nCommission: {1}",
              sales.ToString("C"), commission.ToString("C"));
        }
    }
}
