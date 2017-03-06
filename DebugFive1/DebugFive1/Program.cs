using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DebugFive1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PASS_1 = "home";
            const string PASS_2 = "lady";
            const string PASS_3 = "mouse";
            String password;
            

            Write("Please enter your password ");
            password = Console.ReadLine();

            while (password == PASS_1 || password == PASS_2 || password == PASS_3)
            {
                WriteLine("valid password");
                password = ReadLine();
                
               
            }
          
            WriteLine("invalid password...Try again");
            
        }
    }
}
