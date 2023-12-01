using Lab09;

class Program
{
    public static void Main()
    {
        Triangle t1 = new((1, 8), (4, 0), (4, 9));
        Console.WriteLine("Triangle side A length is:{0:0.00}\nTriangle side B length is:{1:0.00}\nTriangle side C length is:{2:0.00}\n",
        t1.GetSides().sideA, t1.GetSides().sideB, t1.GetSides().sideC);
        Console.WriteLine("Triangle is {0}", t1.IsValid());
        Console.WriteLine("Triangle perimeter is {0:0.00}", t1.GetPerimeter());
        Console.WriteLine("Triangle area is {0:0.00}\n", t1.GetArea());
        t1.Rotate(90);
        Rectangle r1 = new((10, 26), (45, 26), (10, 10), (45, 10));   
        Console.WriteLine("Rectangle is {0}", r1.IsValid());
        Console.WriteLine("Rectangle width is {0:0.00}\nRectangle height is {1:0.00}\n", r1.GetSides().width, r1.GetSides().height);
        Console.WriteLine("Rectangle perimeter is {0:0.00}", r1.GetPerimeter());
        Console.WriteLine("Rectangle area is {0:0.00}\n", r1.GetArea());
        r1.Rotate(45);
        Circle c1 = new((-4, -3), (0, 0));
        Console.WriteLine("Cirle is {0}", c1.IsValid());
        Console.WriteLine("Cirle radius is {0:0.00}\n", c1.GetRadius());
        Console.WriteLine("Cirle perimeter is {0:0.00}", c1.GetPerimeter());
        Console.WriteLine("Cirle area is {0:0.00}\n", c1.GetArea());
    }
}
