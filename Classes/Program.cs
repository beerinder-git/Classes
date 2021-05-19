using System;

namespace Classes
{

    public class Car
    {

        // Member variables

        // Color of the car
        public string color { get; set; }

        // Make of the car
        private string make { get; set; }

        // Year of the car
        public string year { get; set; }

        // Functions
        // 1 . Constructors
        public Car()
        {
            Console.WriteLine("I am in Constructor");
            color = "RED";
            make = "Toyota";
            year = "2021";
        }
        // 2 . Methods/Functions

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car car_obj = new Car();

            
        }
    }
}
