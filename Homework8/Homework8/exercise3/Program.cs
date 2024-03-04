internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 0, 1, 2, 22, 5, 2, 3 };

        Console.WriteLine("Максимальный элемент: {0}", array.MaxElement());
    }
}

static class IntExtantion
{
    private static int Element = 0;
    public static int MaxElement(this int[] array)
    {
        Element = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            Element = array[i] > Element ? array[i] : Element;
        }

        return Element;
    }
}