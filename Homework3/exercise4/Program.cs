internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("byte {0}", default(byte));
        Console.WriteLine("sbyte {0}", default(sbyte));
        Console.WriteLine("short {0}", default(short));
        Console.WriteLine("ushort {0}", default(ushort));
        Console.WriteLine("int {0}", default(int));
        Console.WriteLine("uint {0}", default(uint));

        if (default(int?) == null)
        {
            Console.WriteLine("int? {0}", "null");
        }
        else
            Console.WriteLine("int? {0}", default(int?));

        Console.WriteLine("float {0}", default(float));
        Console.WriteLine("long {0}", default(long));
        Console.WriteLine("ulong {0}", default(ulong));
        Console.WriteLine("double {0}", default(double));
        Console.WriteLine("decimal {0}", default(decimal));

        if (default(string) == null)
           Console.WriteLine("string {0}", "null");

        Console.WriteLine("char U+{0:x4}", (int)default(char));

        Console.WriteLine("bool {0}", default(bool));

        Console.ReadLine();
    }
}