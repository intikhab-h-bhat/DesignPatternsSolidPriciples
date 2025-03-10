
namespace DesignPatternsSolidPriciples.SOLID.L
{

    public class NewRectangle : NewShapes
    {
        public double Length {get;set;}

        public double Width {get;set;}


        public override double Area => Length* Width;
        
    }



}