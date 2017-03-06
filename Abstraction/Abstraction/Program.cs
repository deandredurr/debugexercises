using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Abstraction
{
    public class Car
    {
        public int mileage = 85;
        public string color = "red";
        private string formula = "a + b";
        //public so accessible outside class

        public int getMileage()
        {
            return mileage;
        }

        //It's public - so accessible outside class

        public string GetColor()
        {
            return color;
        }
        // It's private - so NOT accessible outside class

        private string GetEngineFormula()
        {
            return formula;
        }
        //It's Public - so accessible outside class
        public string DisplayEngineFormula()
        {
            return GetEngineFormula();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car objCar = new Car();
            Console.WriteLine("Car mileage is :" + objCar.getMileage());
            //accessible outside "Car"
            Console.WriteLine("Car color is :" + objCar.GetColor());

            //Can't call this method because it is inaccessible outside "Car"
            //objCar.GetEngineFormula();
            Console.WriteLine("Car formula is : " + objCar.DisplayEngineFormula());
            Console.ReadKey();
        }
    }
}
