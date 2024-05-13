namespace AreaOfCircle 
{   
       public class Circle 
    {
        public static double AreaCircle(float radius) 
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        public static double Circumference(float radius)
        {
            return (2 * Math.PI * radius);
        }

        public static double Diameter(float radius) 
        {
            return (2 * Math.PI * radius);
        }

        public static double GallonsForTrip (float milesPerGallon, float radius) 
        {
            return Circumference(radius)/milesPerGallon;
        }

    }
}