using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ParameterArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mark", "Paulette", "Carol", "James" };
            DisplayStrings("Ginger");
            DisplayStrings("George", "Maria", "Thomas");
            DisplayStrings(names);
        }

        private static void DisplayStrings(params string[] people)
        {
            foreach (string person in people)
                Write("{0}", person);
            WriteLine("\n---------------");
        }
    }
}
