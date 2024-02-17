internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите свой рост");
        
        int.TryParse(Console.ReadLine(), out int height);

        Console.WriteLine(nameof(height) + ": " + height);
        Console.ReadLine();
    }
}