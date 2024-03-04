internal class Program
{
    private static void Main(string[] args)
    {
        Bag bag = new Bag();

        Item[] items = {new Item("Зеркало"), new Item("Помада"), new Item("Расческа"), new Item("Кошелек"), new Item("Паспорт")
                    , new Item("Телефон"), new Item("Наушники"), new Item("Ключи"), new Item("Проездной") };

        for (int i = 0; i < items.Length; i++)
        {
            bag.AddItem(items[i]);
        }

        bool isClosed = true;

        bag.ChangeIsOpen(isClosed);

        bag.GetItem(8);

        bag.GetItem(4);

        isClosed = false;

        bag.ChangeIsOpen(isClosed);

        bag.AddItem(items[4]);

        Console.ReadKey();
    }
}

public class Bag
{
    private Item[] Items;

    private bool _isOpen;

    public Bag()
    {
        Items = new Item[8];
    }

    public void ChangeIsOpen(bool flag)
    {
        _isOpen = flag;
    }

    public void AddItem(Item item)
    {
        if (_isOpen == true) 
        {
            Console.WriteLine("Сумка открыта");
            return; 
        }

        if (Array.IndexOf(Items, null) == -1)
        {
            Console.WriteLine("Сумка заполнена");
            return;
        }

        for (int i = 0; i < Items.Length; i++)
        {
            if (Items[i] == null)
            {
                Items[i] = item;
                break;
            }
            
        }

        Console.WriteLine("Вещь {0} добавлена", item.GetName());

        return;
    }

    public Item GetItem (int index)
    {
        if (_isOpen == false)
        {
            Console.WriteLine("Сумка закрыта");
            return null;
        }

        if(index > 7 || Items[index] == null)
        {
            Console.WriteLine("Такой вещи нет в сумке");
            return null;
        }

        Console.WriteLine("Вещь {0} вынута", Items[index].GetName());

        Item item = Items[index];

        Items[index] = null;

        return item;
    }
}