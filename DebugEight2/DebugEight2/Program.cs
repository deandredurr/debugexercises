using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DebugEight2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numericScore = 82;
            string letterScore = "B";
            Write("Score was {0}. ", numericScore);
            GiveBonus(ref numericScore);
            WriteLine("Now it is {0}.", numericScore);
            Write("Grade was ", letterScore);
            GiveBonus(ref letterScore);
            WriteLine("Now it is ", letterScore);
        }
        private static void GiveBonus(int ref testScore)
        {
            const int BONUS = 5;
            testScore = BONUS;
        }
        private static void GiveBonus(string ref letterScore)
        {
            const string BONUS = "+";
            letterScore = BONUS;
        }
    }
}
