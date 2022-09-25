using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediatte
{
    public class AnonymusTypes
    {
        //Anonymus types allow you to store a set of readonly properties
        //without being needed to declare their type of data
        //type of data is solved at run-time
        //you can declare a block of variables using var 
        // or using dynamic

        public void TestingDynamic()
        {
            //using var to declare a block or readonly anonymus  props 
            var car = new { Model = "Bugatti", Year = 2006, Price = 250.00000 ,isExpensive = true};

            Console.WriteLine($"This car is a {car.Model} its price is {car.Price} , it was manufactured{car.Year}.");

            Console.WriteLine($"Is car Expensive {car.isExpensive} ");

            //using dynamic to declare a set of anonymus variables
            dynamic firstNumber = 1;
            dynamic firstName = "John";
            dynamic isOld = false;
            dynamic age = 24;

            Console.WriteLine($"My first dynamic is {firstNumber},second dynamic is {firstName}, third dynamic is {isOld}");
            Console.WriteLine($"Fourth is {age} ");

        }




    }
}
