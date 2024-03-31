
using System;

abstract class Animal
{
    protected string name;
    protected int numOfLegs;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetNumOfLegs(int legs)
    {
        this.numOfLegs = legs;
    }
    public int GetNumOfLegs()
    {
        return numOfLegs;
    }
    public abstract void DisplayAnimal();
}

internal interface ICarnivore
{
    public string TypeC { get; }
    public string FoodC { get; set; }

    public void DisplayEatC();
}

internal interface IHerbivore
{
    public string TypeH { get; }
    public string FoodH { get; set; }

    public void DisplayEatH();
}

class Cat : Animal, ICarnivore
{
    private string sound;
    private string colour;

    public Cat(string sound, string colour)
    {
        this.sound = sound;
        this.colour = colour;
        name = "Cat";
        numOfLegs = 4;
    }

    public override void DisplayAnimal()
    {
        Console.WriteLine($"It is a {TypeC} named {name}. {name} has {numOfLegs} legs and it is {colour} and says {sound}");
    }

    public string TypeC 
    { 
        get
        {
            return "Carnivore " + this.GetType().FullName;
        }
    }

    public string FoodC 
    {
        get 
        {
            return TypeC + " Diet: meet, fish";
        } 
        set
        {
            value = value.ToLower();

            if (value.ToLower() == "meet" || value.ToLower() == "fish")
            {
                Console.WriteLine($"{name} is eating {value}");
            }
            else
            {
                Console.WriteLine($"{name} doesn't eat {value}");
            }
        }
    }

    public void DisplayEatC()
    {
        Console.WriteLine(FoodC);
    }
}

class Elephant : Animal, IHerbivore, IEquatable<Elephant>
{
    private string sound;
    private string colour;
    public int Size { get; set; }

    public Elephant(string sound, string colour, int size = 1)
    {
        this.sound = sound;
        this.colour = colour;
        name = "Elephant";
        numOfLegs = 4;
        this.Size = size;
    }

    public override void DisplayAnimal()
    {
        Console.WriteLine($"It is a {TypeH} named {name}. {name} has {numOfLegs} legs and {Size} size and it is {colour} and says {sound}");
    }

    public string TypeH
    {
        get
        {
            return "Herbivore " + this.GetType().FullName;
        }
    }

    public string FoodH
    {
        get
        {
            return TypeH + " Diet: grass, leaf";
        }
        set
        {
            value = value.ToLower();

            if (value == "grass" || value == "leaf")
            {
                Console.WriteLine($"{name} is eating {value}");
            }
            else
            {
                Console.WriteLine($"{name} doesn't eat {value}");
            }
        }
    }

    public void DisplayEatH()
    {
        Console.WriteLine(FoodH);
    }

    public bool Equals(Elephant? other)
    {
        if (other is null | other.Size != this.Size)
            return false;
        else
            return true;
    }
}

class Bear : Animal, IHerbivore, ICarnivore
{
    private string sound;
    private string colour;

    public Bear(string sound, string colour)
    {
        this.sound = sound;
        this.colour = colour;
        name = "Bear";
        numOfLegs = 4;
    }

    public override void DisplayAnimal()
    {
        Console.WriteLine($"It is a {TypeC} named {name}. {name} has {numOfLegs} legs and it is {colour} and says {sound}");
    }

    public string TypeH
    {
        get
        {
            return "Herbivore " + this.GetType().FullName;
        }
    }

    public string TypeC
    {
        get
        {
            return "Carnivore " + this.GetType().FullName;
        }
    }

    public string FoodH
    {
        get
        {
            return TypeH + " Diet: berry, apple";
        }
        set
        {
            value = value.ToLower();

            if (value == "berry" || value == "apple")
            {
                Console.WriteLine($"{name} is eating {value}");
            }
            else
            {
                Console.WriteLine($"{name} doesn't eat {value}");
            }
        }
    }

    public string FoodC
    {
        get
        {
            return TypeC + " Diet: meet, fish";
        }
        set
        {
            value = value.ToLower();

            if (value == "meet" || value == "fish")
            {
                Console.WriteLine($"{name} is eating {value}");
            }
            else
            {
                Console.WriteLine($"{name} doesn't eat {value}");
            }
        }
    }
    public void DisplayEatH()
    {
        Console.WriteLine(FoodH);
    }

    public void DisplayEatC()
    {
        Console.WriteLine(FoodC);
    }
}

static class Zoo
{
    public static void Add(Animal animal)
    {
        Type type = animal.GetType();

        if (type.GetInterfaces().Contains(typeof(ICarnivore)))
        {
            Console.WriteLine($"{animal.GetName()} is placed in an enclosure for predators \n");
        }
        else if (type.GetInterfaces().Contains(typeof(IHerbivore)))
        {
            Console.WriteLine($"{animal.GetName()} is placed in an enclosure for herbivores \n");
        }

    }

}

internal class Program
{
    private static void Main()
    {
        Cat cat = new Cat("meow-meow", "ginger");
        cat.SetName("Tom");
        cat.DisplayAnimal();
        cat.DisplayEatC();
        cat.FoodC = "fish";
        cat.FoodC = "rice";

        Zoo.Add(cat);

        Elephant elephant1 = new Elephant("muuu", "grey");
        elephant1.SetName("El");
        elephant1.DisplayAnimal();
        elephant1.DisplayEatH();
        elephant1.FoodH = "leaf";
        elephant1.FoodH = "rice";
        elephant1.Size = 2;

        Zoo.Add(elephant1);

        Elephant elephant2 = new Elephant("muuu", "grey", 3);
        elephant2.SetName("Od");
        elephant2.DisplayAnimal();
        elephant2.DisplayEatH();
        elephant2.FoodH = "leaf";
        elephant2.FoodH = "rice";

        Console.WriteLine("Is elephant El equal elephant Od? - {0}", elephant1.Equals(elephant2));

        Zoo.Add(elephant2);

        Bear bear = new Bear("aaaa", "brown");
        bear.SetName("Potapych");
        bear.DisplayAnimal();
        bear.DisplayEatH();
        bear.FoodH = "berry";
        bear.FoodH = "meet";
        bear.DisplayEatC();
        bear.FoodC = "fish";
        bear.FoodC = "rice";

        Zoo.Add(bear);

        Console.ReadKey();
    }
}