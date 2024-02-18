internal class Program
{
    private static void Main()
    {
        string[] array = { "apple", "banana", "orange" };
        string? value = "banana";

        if (array == null || array.Length == 0)
        {
            Console.WriteLine("Пустой массив");
            return;
        }

        if (string.IsNullOrEmpty(value) == true)
        {

            return;

        }

        array = AddValueToArray(array, value);

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);

        }

        Console.ReadLine();

    }

    public static string[] AddValueToArray(string[] array, string? value)
    {

        if (string.IsNullOrEmpty(value) == true || array == null)
        {

            return null;

        }

        string valueToUpper = value.ToUpper();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].ToUpper() == valueToUpper)
            {
                return array;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == null)
            {
                array[i] = value;
                return array;
            }
        }

        Array.Resize(ref array, array.Length + 1);
        int ln = array.Length - 1;
        array[ln] = value;

        return array;

    }

}