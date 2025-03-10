

namespace DesignPatternsSolidPriciples.SOLID.O
{

    public class Circle : ShapeExample
    {

        public  double radius {get;set;}

        public override void CalulateArea()
        {
            Console.WriteLine(Math.PI*Math.Pow(radius,2));
        }
    }
}