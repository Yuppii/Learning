internal class Program
{
    private static void Main()
    {
        int start = 201;
        int end = 500;
        string result = "200";

        while (start <= end)
        {
            if (start % 17 == 0) 
            {
                result += ',' + start.ToString();
            }
            
            start++;
        }

        Console.WriteLine(result);
        Console.ReadLine();
    }
}