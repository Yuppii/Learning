class MobileNetwork
{

}

class MobileNetwork<T> where T : MobileNetwork
{
    public T Network { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}