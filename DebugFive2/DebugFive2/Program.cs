using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugFive2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ITEM209 = 209;
            const int ITEM312 = 312;
            const int ITEM414 = 414;
            const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
            double price;
            int stockNum;
            Write("Please enter the stock number of the item you want ");
            stockNum = Convert.ToInt32(ReadLine());
            while (stockNum == ITEM209 || stockNum == ITEM312 || stockNum == ITEM414)
            {
                WriteLine("valid stock number. Please enter again. ");
                stockNum = Convert.ToInt32(ReadLine());

            }
                if (stockNum == ITEM209)
                    price = PRICE209;

                else
                   if (stockNum == ITEM312)
                    price = PRICE312;
                else
                    price = PRICE414;

                WriteLine("The price for item # {0} is {1}}", stockNum, price.ToString("C"));
            
        }
    }
}
