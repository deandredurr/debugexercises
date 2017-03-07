using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugEight1
{
    class Program
    {
        static void Main(string[] args)
        {
            int orderNum, quantity;
            double total;
            const double PRICE_EACH = 3.99;
            GetData(out orderNum, out quantity);
            total = quantity * PRICE_EACH;
            WriteLine("Order #{0}. Quantity ordered = {1}",
                orderNum, quantity);
            WriteLine("Total is {0}", total.ToString("C"));
        }
        private static void GetData(out int order, out int amount)
        {
            String s1, s2;
            Write("Enter order number ");
            s1 = ReadLine();
            Write("Enter quantity ");
            s2 = ReadLine();
            order = Convert.ToInt32(s1);
            amount = Convert.ToInt32(s2);
        }
    }
}
