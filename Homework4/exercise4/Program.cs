internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите Ваш доход за месяц в рублях: ");
        string? input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal taxByIncome) == true)
        {

            if (CountTax(ref taxByIncome) == true)
            {
                Console.WriteLine();
                Console.WriteLine("Ваш налог на доход составил {0} рублей", taxByIncome);
            }
            else 
            { 
                Console.WriteLine("Налог не начислен"); 
            }

            
        }
        else
        {
            Console.WriteLine("Введено некорректное значение");
        }

        Console.ReadLine();

    }

    public static bool CountTax (ref decimal taxByIncome)
    {

        if (taxByIncome < 0)
        {
            return false;
        }
        else
        {
            const decimal tax = (decimal)0.13;

            taxByIncome = decimal.Multiply(taxByIncome, tax);

            return true;
        }

    }
}