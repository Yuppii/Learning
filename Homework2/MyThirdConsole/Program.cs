internal class Program
{
    private static void Main(string[] args)
    {
        int a = 3;
        byte b = (byte)a;

        string? c = Console.ReadLine();
        string? d = Console.ReadLine();
        string? r = Console.ReadLine();


        if (int.TryParse(c, out var number1) && int.TryParse(d, out var number2) && int.TryParse(r, out var number3) == true)
        {
            //int result = (number1 + number2 + number3) / 3;
            Console.WriteLine($"Результат арифметического сложения = {(number1 + number2 + number3) / 3}");
        }
        else
        {
            Console.WriteLine("Числа введены некорректно");
        }

        Console.ReadLine();
    }
}