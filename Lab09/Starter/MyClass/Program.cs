using MyClass;

class Program
{
    public static void Main()
    {
        Book b1 = new("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
        Magazine m1 = new("О природе", 5, "Земля и мы", 2014, 1235, true);
        m1.TakeItem();
        m1.Show();
        m1.IfSubs = true;
        m1.Subs();

        Console.WriteLine("\n Тестирование полиморфизма");
        Item ite;

        ite = b1;
        ite.TakeItem();
        ite.Return();
        ite.Show();
        ite = m1;
        ite.TakeItem();
        ite.Return();
        ite.Show();
    }
}
