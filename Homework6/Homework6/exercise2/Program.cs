internal class Program
{
    static int aLenght;
    static int aHeight;


    static int bLenght;
    static int bHeight;

    static int maxLength;
    static int maxHeight;

    private static void Main()
    {
        //int[,] a = { { 1, 2, 3 }, { 1, 2, 3 } };
        int[,] a = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        int[,] b = { { 1, 2, 3 }, { 1, 2, 3 } };

        aLenght = a.GetLength(0);
        aHeight = a.GetLength(1);

        bLenght = b.GetLength(0);
        bHeight = b.GetLength(1);

        maxLength = aLenght > bLenght ? aLenght : bLenght;
        maxHeight = aHeight > bHeight ? aHeight : bHeight;

        aLenght--;
        aHeight--;

        bLenght--;
        bHeight--;

        int[,] result = SumArray(a, b);

        Console.WriteLine("Массив A + массив B = "); 

        for (int i = 0; i < maxLength; i++)
        {
            for (int j = 0; j < maxHeight; j++)
            {
                Console.Write(result[i, j]);
                Console.Write(", ");
            }

            Console.WriteLine();

        }

        Console.ReadLine();
    }

    private static int[,] SumArray(int[,] a, int[,] b)
    {
        int[,] result = new int[maxLength, maxHeight];

        for (int i = 0; i < maxLength; i++)
        {
            for (int j= 0; j < maxHeight; j++)
            {
                result[i, j] = (aLenght < i || aHeight < j ? 0 : a[i, j]) + (bLenght < i || bHeight < j ? 0 : b[i, j]);
            }
        }

        return result;

    }
}