
namespace DesignPatternsSolidPriciples.SOLID.O
{

    public class Rectangle : ShapeExample
    {

        public double Length{get;set;}

        public double Width {get;set;}

        public override void CalulateArea()
        {
            Console.Write(Length * Width);
        }
    }


}