using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FlexibleArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int x;
            int[] p =  { 1, 3, 5, 6, 7};
            int[] q = { 3, 5, 7, 9, 10, 11 };
            int[] s = { 5, 10, 17, 4 };


            WriteLine("Enter some numbers Dude!");
            for (x = 0; x < p.Length; x++)
                Write("{0,5}", p[x]);
            WriteLine();
            integerone(p);
            WriteLine("Press enter to view Array S");
            integerone(q);
            integerone(s);

        }
        private static void integerone(int[] one)
        {
            int x;
            
            
            
            WriteLine("Here is the array");
            for (x = 0; x < one.Length; x++)
                Write("{0}", one[x]);
            WriteLine();
            //for (x = 0; x < one.Length; x++)
                int sum = one.Sum();
            WriteLine("Here is the Sum of the array");
            Console.WriteLine(sum);
            ReadLine();
        }
        

    }
}
