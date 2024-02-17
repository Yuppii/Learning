internal class Program
{
    private static void Main(string[] args)
    {
        int x = 14, y = 1, z = 5;

        x += y - x++ * z;
        //x = 14 + 1 - 14 * 5 = 15 - 70 = -55 

        Console.WriteLine(x);

        z = --x - y * 5;
        // z = -56 - 1 * 5 = -61

        Console.WriteLine(z);

        y /= x + 5 % z;
        // y = 1 / (-56 + 5 % (-61)) = 1 / (-56 + 5) = 0

        Console.WriteLine(y);
        
        z = x++ + y * 5;
        //z = -56 + 0 * 5 = -56

        Console.WriteLine(z);

        x = y - x++ * z;
        //x = 0 - (-55) * (-56) = -3080
    }

}