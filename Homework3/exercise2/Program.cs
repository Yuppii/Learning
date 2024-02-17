internal class Program
{
    private static void Main(string[] args)
    {
        string? status = null;

        do
        {
            Console.WriteLine("Введите число");

            if (double.TryParse(Console.ReadLine(), out double a) == true && a % 2 == 0)
            {
                Console.WriteLine("число {0} четное", a);
            }
            else if (a % 2 != 0)
            {
                Console.WriteLine("число {0} нечетное", a);
            }
            else
            {
                Console.WriteLine("Введено не число, вы хотите прервать программу? (yes/no)");
                status = Console.ReadLine();
            }

        }
        while (status != "yes");
        return;
    }
}