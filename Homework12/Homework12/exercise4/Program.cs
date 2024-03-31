enum Sex : byte
{
    woman,
    man
}

class Person : IComparable
{
    public int Age { get; set; }
    public Sex Sex { get; set; }

    public Person(int a, Sex s)
    {
        Age = a;
        Sex = s;
    }

    public int CompareTo(object? obj)
    {
        if (obj is Person)
        {
            Person p = (Person)obj;

            if (p.Sex == this.Sex)
            {
                return this.Age - p.Age;
            }
            else
            {
                return (byte)this.Sex - (byte)p.Sex;
            }
        }
        else
        {
            throw new ArgumentException("Некорректное значение параметра");
        }
    }
}

class PersonComparer : IComparer<Person?>
{

    public int Compare(Person? x, Person? y)
    {
        if (x is null | y is null)
        {
            throw new ArgumentException("Некорректное значение параметра");
        }
        else
        {
            return x.CompareTo(y);
        }
    }
}

internal class Program
{
    private static void Main()
    {
        List<Person> listOfPerson = new List<Person>()
        {
            new Person(27, Sex.man),
            new Person(18, Sex.man),
            new Person(41, Sex.man),
            new Person(67, Sex.man),
            new Person(5, Sex.man),
            new Person(27, Sex.woman),
            new Person(18, Sex.woman),
            new Person(41, Sex.woman),
            new Person(67, Sex.woman),
            new Person(5, Sex.woman),
        };

        Console.WriteLine("Лист людей: \n");

        foreach (Person person in listOfPerson)
        {
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Sex);
        }

        //Console.WriteLine("\nОтсортированный лист людей: \n");

        //listOfPerson.Sort();

        //foreach (Person person in listOfPerson)
        //{
        //    Console.WriteLine(person.Age);
        //    Console.WriteLine(person.Sex);
        //}

        Console.WriteLine("\nОтсортированный PersonComparer лист людей: \n");

        PersonComparer pc = new PersonComparer();

        listOfPerson.Sort(pc); //так нужно было сделать? объясните, пожалуйста, для чего передавать PersonComparer

        foreach (Person person in listOfPerson)
        {
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Sex);
        }
    }
}