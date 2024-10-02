using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSolidPriciples.Abstraction
{
    public abstract class  UsingAbstractClass
    {
        public abstract void StartCar();

        public  void StopCar()
        {
            Console.WriteLine("Stop The vehicle");
        }

    }

    public class CarType:UsingAbstractClass { 
    
        public override void StartCar()
        {

            Console.WriteLine("Starting Car");
        }

      
    
    }
}
