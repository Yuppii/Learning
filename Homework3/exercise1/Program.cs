internal class Program
{
    private static void Main(string[] args)
    {
        const decimal pi = (decimal)Math.PI;

        Console.WriteLine("Введите r:");
        string? r = Console.ReadLine();

        Console.WriteLine("Введите l:");
        string? l = Console.ReadLine();

        if(decimal.TryParse(r, out var radius) && decimal.TryParse(l, out var lenth) == true)
        {
            decimal S = pi * radius * (radius + lenth);
            Console.WriteLine("S = {0}", S);
        }
        else
        {
            Console.WriteLine("Введены некорректные данные");
        }
    }
}