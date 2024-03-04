namespace cone
{
    public class Cone
    {
        private double radius;

        private double height;

        private const double pi = Math.PI;
        public Cone(double r, double h)
        {
            radius = r;
            height = h;
        }

        public double GetFoundationSquare()
        {
            return pi * Math.Pow(radius, 2);
        }

        public double GetFullSquare()
        {
            return GetFoundationSquare() + pi * radius * Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
        }
    }
}
