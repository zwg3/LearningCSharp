using Lab09;

class Program
{
    public static void Main()
    {
        Shape c1 = new(1, 2);
        Shape c2 = new(2, 3);
        Shape c3 = new(3, 4);
        Triangle tri = new(c1, c2, c3);
        tri.PrintTriangle();
        
        

    }
}
