namespace cone;

internal class Program
{
    private static void Main()
    {
        double radius = 2;

        double height = 3;

        Cone cone  = new Cone(radius, height);

        Console.WriteLine("Площадь основания концуса: {0}; площадь всего конуса: {1}", cone.GetFoundationSquare(), cone.GetFullSquare());
    }
}