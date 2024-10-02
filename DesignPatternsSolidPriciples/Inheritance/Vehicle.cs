using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSolidPriciples.Inheritance
{
    public class Vehicle
    {
        public string? Brand {  get; set; }
        public string? Model { get; set; }
        public int NumberOfWheels { get; set; }

        public void Start()
        {
            Console.WriteLine("Start");
        }

        public void Stop()
                {
                    Console.WriteLine("Stop");
                }



    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

    }

    public class Bike:Vehicle
    {
        public string? Type { get; set; }

    }
}
