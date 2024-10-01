using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSolidPriciples.Abstraction
{
    public abstract class  UsingAbstractClass
    {
        public abstract void Start();

        public  void Stop()
        {
            Console.WriteLine("Stop The vehicle");
        }

    }

    public class Car:UsingAbstractClass { 
    
        public override void Start()
        {

            Console.WriteLine("Start The Vehicle");
        }
    
    }
}
