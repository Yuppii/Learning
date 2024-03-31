public class Pupil
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public Pupil(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
}

public class Principal
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Principal(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }
    public void Hello(Pupil p)
    {
        Console.WriteLine("Hello parents of " + p.Name + " " + p.Surname + "!");
    }
}

public class School
{
    public Principal Principal { get; set; }
    public List<Pupil> Pupils { get; set; } = new List<Pupil>(0);

    public School(Principal p)
    {
        Principal = p;
    }

    public event Action<Pupil> AddPupilEvent = null;

    public Pupil SearchPupil(Func<Pupil, bool > d)
    {

       foreach(var p in Pupils) 
       { 
            if(d(p))
            {
               return p;
            }
       }

        return null;
    }

    public void AddPupil(Pupil p)
    {
        Pupils.Add(p);
    }

    public void InvokeEvent(Pupil p)
    {
        AddPupilEvent.Invoke(p);
    }
}
internal class Program
{
    private static void Main()
    {
        List<Pupil> pupils = [new Pupil("Ivan", "Vlasov",8), new Pupil("Denis", "Smirnov", 9), new Pupil("Masha", "Sidorova", 8)];

        Principal principal = new Principal("Vasya", "Petrov");

        School s = new(principal)
        {
            Pupils = pupils
        };

        Pupil p = s.SearchPupil(k =>
        {
            bool result = false;
            if (k.Name == "Ivan" && k.Surname == "Petrov")
            { result = true; }
            return result;
        });

        if (p != null)
        {
            Console.WriteLine("\n Найден " + p.Name + " " + p.Surname);
        }
        else
        {
            Console.WriteLine("\n Нет такого ученика");
        }

        s.AddPupilEvent += s.AddPupil;
        s.AddPupilEvent += principal.Hello;

        s.InvokeEvent(new Pupil("Anna", "Kuzina", 7));

        Console.ReadKey();
    }
}