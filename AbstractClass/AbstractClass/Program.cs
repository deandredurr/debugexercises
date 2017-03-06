using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Describe());
            Console.ReadKey();
        }
    }

    #region SuperClass
    abstract class FourLeggedAnimal
        {
        public virtual string Describe()
        {
            return "Not much is known about this four legged creature";
        }
            
        }
#endregion SuperClass

#region SubClass
class Dog : FourLeggedAnimal
    {

    }
    class Cat : FourLeggedAnimal
    {

}
} 

#endregion SubClass


