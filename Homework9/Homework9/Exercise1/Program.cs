abstract class Animal
{
    public abstract void Live();
}

class HerbivorAnimal : Animal
{
    public static void EatGrass()
    {
        Console.WriteLine("Жует траву" + "\n");
    }

    public override void Live()
    {
        Console.WriteLine("Травоядное живет");
        EatGrass();
    }

}

class Predator : Animal
{
    public bool IsHungry { get; set; }

    public static void Bite()
    {
        Console.WriteLine("Охотится" + "\n");
    }

    public override void Live()
    {
        Console.WriteLine("Хищник живет");

        if (IsHungry)
        {
            Bite();
        }
        else 
        { 
            Console.WriteLine("Не голоден" + "\n"); 
        }
    }

}

class Rabbit : HerbivorAnimal
{
   
}

class Deer : HerbivorAnimal
{

}

class Wolf : Predator
{

}

class Bear : Predator
{

}

class Zoo
{
    public void Add(Animal animal)
    {
        Type type = animal.GetType();

        if (type.BaseType == typeof(Predator))
        {
            Console.WriteLine(type.ToString());
            Console.WriteLine("Животное помещено в вальер для хищников \n");
        }
        else if(type.BaseType == typeof(HerbivorAnimal))
        {
            Console.WriteLine(type.ToString());
            Console.WriteLine("Животное помещено в вальер для травоядных \n");
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Rabbit rabbit = new Rabbit();
        rabbit.Live();

        Deer deer = new Deer();
        deer.Live();

        Wolf wolf = new Wolf();
        wolf.IsHungry = true;
        wolf.Live();

        Bear bear = new Bear();
        bear.IsHungry = false;
        bear.Live();

        Zoo GrodnoZoo = new Zoo();

        GrodnoZoo.Add(rabbit);
        GrodnoZoo.Add(deer);
        GrodnoZoo.Add(wolf);
        GrodnoZoo.Add(bear);

    }
}
