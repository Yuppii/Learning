internal class Program
{
    private static void Main()
    {
        Item item = new Item("Первичное");

        Console.WriteLine(item.GetName());

        item.SetName("Измененное");

        Console.WriteLine(item.GetName());
    }
}