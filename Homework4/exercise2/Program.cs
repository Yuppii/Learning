internal class Program
{
    private static void Main()
    {
        Console.WriteLine("******" + "\n" + "\n" + "   AAA   " + "\n"  + "\n" + "******");

        for (;;)
        {
            Console.WriteLine("\n" + "Введите один из символов: W, S, A, D.");

            string action = Console.ReadLine();

            switch (action)
            {
                case "W":
                    Console.WriteLine("Сдвиг вверх");
                    Console.WriteLine("******" + "\n" + "   AAA   " + "\n" + "\n" + "******");
                    continue;
                case "S":
                    Console.WriteLine("Сдвиг вниз");
                    Console.WriteLine("******" + "\n" + "\n" + "   AAA   "  + "\n" + "******");
                    continue;
                case "A":
                    Console.WriteLine("Сдвиг вправо");
                    Console.WriteLine("******" + "\n" + "\n" + "      AAA" + "\n" + "\n" + "******");
                    continue;
                case "D":
                    Console.WriteLine("Сдвиг влево");
                    Console.WriteLine("******" + "\n" + "\n" + "AAA   " + "\n" + "\n" + "******");
                    continue;
                default:
                    Console.WriteLine("\n" + "Введен символ \"{0}\" вне перечня - перемещение не выполнено", action);
                    break;
            }

            break;

        }

        Console.WriteLine("\n" + "Конец игры");

        Console.ReadLine();

    }
}