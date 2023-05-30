using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    interface ICar
    {
        void carColor();  // No body for this interface method
    }

    // Class to implement the ICar interface
    class Car01 : ICar
    {
        public void carColor()
        {
            Console.WriteLine("The color for our car is white!!");
        }

        class MyProgram
        {
             static void Main(string[] args)
            {
                Car01 newCar = new Car01();
                newCar.carColor();
            }
        }
    }
}
