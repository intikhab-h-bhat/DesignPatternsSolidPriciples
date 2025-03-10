

namespace DesignPatternsSolidPriciples.SOLID.I{

    public class Sphere3D : IShapes3D
    {

        public double radius {get;set;}

        public double Area()
        {
           return (4.00)*Math.PI*Math.Pow(radius,2);
        }

        public double Volume()
        {
           return (4.00/3.00)*Math.PI*Math.Pow(radius,3);
        }
    }



}