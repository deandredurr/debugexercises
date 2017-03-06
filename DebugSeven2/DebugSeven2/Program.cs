using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugSeven2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string addressee = "Ms. Brooke Jefferson";
            int zipCode = 60007;
            string cityAndState = "Elk Grove, IL";
            AddressMethod(addressee, zipCode);
            WriteLine("-----------------------");
            AddressMethod(addressee, cityAndState);
            WriteLine("-----------------------");
        }
        private static void AddressMethod(string person, int num)
        {
            WriteLine("To : {0}", person);
            WriteLine("Zip: {0}",  num);
        }
        private static void AddressMethod(string person, string city)
        {
            WriteLine("To : {0}", person);
            WriteLine("{0}", city);
        }
    }
}
