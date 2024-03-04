namespace arrayWorker;

internal class Program
{
    private static void Main(string[] args)
    {
        object[] array = { 1,2,3,4 };

        ArrayWorker arrayWorker = new ArrayWorker(array);

        if (array != null)
        {
            array = arrayWorker.Reverse();
        }
        else 
        {
            Console.WriteLine("Массив не задан");
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("{0}: {1}", i, array[i]);
        }

        Console.ReadLine();
    }
}