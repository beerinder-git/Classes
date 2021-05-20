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

        public Car(string car_color, string car_make, string car_year)
        {
            color = car_color;
            make = car_make;
            year = car_year;
        }
        // 2 . Methods/Functions

        public void print_value()
        {
            Console.WriteLine("Color of the car {0}", color);
            Console.WriteLine("Make of the car {0}", make);
            Console.WriteLine("Year of the car {0}", year);
        }

        public void set_value(string make, string color, string year )
        {
            this.color = color;
            this.year = year;
            this.make = make;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car car_obj = new Car();
            Car honda_obj = new Car("RED", "Honda", "2021");
            Car Toyota_obj = new Car("BLACK", "Toyota", "2020");
            honda_obj.print_value();
            Toyota_obj.print_value();
            honda_obj.set_value("Honda", "Grey", "2022");
            Toyota_obj.set_value("Toyota", "White", "2019");
            honda_obj.print_value();
            Toyota_obj.print_value();


        }
    }
}
