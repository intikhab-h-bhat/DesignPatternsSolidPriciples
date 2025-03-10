


namespace DesignPatternsSolidPriciples.SOLID.I
{

    public class Circle2D : IShapes2D
    {

        public double radius {get;set;} 

        public double Area()
        {
            return Math.PI* Math.Pow(radius,2);
        }

        
    }


}