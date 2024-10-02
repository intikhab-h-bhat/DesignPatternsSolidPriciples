using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSolidPriciples.Polymorphism
{
    public class Shape
    {
        public int Sides {  get; set; }
        public string Name { get; set; }

        public virtual void ClosedFig()
        {
            Console.WriteLine("Closed Figure");
        }

    }

    public class Square:Shape
    {

        public override void ClosedFig()
        {
            //base.ClosedFig();
            Console.WriteLine("Square Closed Figure");
        }

    }
    public class Line : Shape
    {

        public override void ClosedFig()
        {
            //base.ClosedFig();
            Console.WriteLine("Not closed Figure");
        }
    }
}
