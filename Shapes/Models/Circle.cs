namespace Shapes.Models
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetCircumference()
        {
            return 2 * 3.14 * Radius;
        }
        public double GetDiameter()
        {
            return 2 * Radius;
        }

    }
}