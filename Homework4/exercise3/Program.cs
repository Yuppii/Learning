using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[10];
        Random rnd = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next();
        }

        int counter = array.Length;

    Label:
        counter--;
        Console.WriteLine(array[counter]);

        if(counter > 0)
        {
            goto Label;
        }

        Console.ReadLine();
    }
} 