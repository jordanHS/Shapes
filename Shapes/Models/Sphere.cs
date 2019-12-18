namespace Shapes.Models
{
    public class Sphere
    {
        public double CubedRadius { get; set; }
        
        public Sphere (double radius)
        {
            CubedRadius = radius * radius * radius;
        }

        public double GetVolume()
        {
            return 1.33 * 3.14 * CubedRadius;
        }     
    
        // public int GetSurfaceArea()
        // {
        //     int length = Face.Length;
        //     return (length * length) * 6;
        // }

    }
}