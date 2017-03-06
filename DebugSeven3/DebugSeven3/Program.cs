using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugSeven3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity;
            double price;
            quantity = (GetQuantity());
            price = CalculatePrice(quantity);
            Test();
            WriteLine("Final price for {0} items is {1}.",
              quantity, price.ToString("c"));
        }

        public static void Test()
        {
            Console.WriteLine("Hello");
        }

        public static int GetQuantity()
        {
            int quantity;
            Write("Enter number of items >> ");
            quantity = Convert.ToInt32(ReadLine());
            return quantity;
            
        }
        private static double CalculatePrice(int quantityOrdered)
        {
            double PRICE_PER_ITEM = 6.00;
            double price = 0;
            double discount = 0.2;
            int[] quanLimits = { 0, 5, 10, 15 };
            double[] limits = { 0, 0.10, 0.14, 0.20 };
            for (int x = limits.Length - 1; x >= 0; --x)
                if (quantityOrdered >= limits[x])
                    discount = limits[x];
           
            price = quantityOrdered * PRICE_PER_ITEM;
            price = price - price * discount;
            return price;
        }
    }
}
