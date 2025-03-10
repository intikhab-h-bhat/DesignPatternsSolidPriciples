

namespace DesignPatternsSolidPriciples.SOLID.L
{

    public class NewSquare : NewShapes
    {
        public double SideLength {get;set;}
        
        public override double Area => SideLength*SideLength;
    }


}