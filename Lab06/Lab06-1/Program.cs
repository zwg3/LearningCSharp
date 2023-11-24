class Triangle
{
    double sideA;
    double sideB;
    double sideC;

    public static void Main()
    {
        Triangle triangle = new();
        triangle.GetTriangle();

        if (IsTriangle(triangle.sideA, triangle.sideB, triangle.sideC)==true)
        {
            Console.WriteLine("This is a triangle!");
            Console.WriteLine("The perimeter is: {0:0.00}", GetPerimeter(triangle.sideA, triangle.sideB, triangle.sideC));
            Console.WriteLine("The area is: {0:0.00}", GetArea(triangle.sideA, triangle.sideB, triangle.sideC));
            Console.WriteLine("Side A is: {0:0.00}\nSide B is: {0:0.00}\nSide C is: {0:0.00}\n", triangle.sideA, triangle.sideB, triangle.sideC);
        }
        else
        {
            Console.WriteLine("This is not a triangle!");
        }
    }

    public void GetTriangle()
    {
        Console.Write("Please enter side A: ");
        sideA = double.Parse(Console.ReadLine());
        Console.Write("Please enter side B: ");
        sideB = double.Parse(Console.ReadLine());
        Console.Write("Please enter side C: ");
        sideC = double.Parse(Console.ReadLine());
    }

    public static double GetPerimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    public static double GetArea(double a, double b, double c)
    {
        double p = GetPerimeter(a, b, c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public static bool IsTriangle(double a, double b, double c)
    {
        if (a + b <= c || a + c <= b || b + c <= a)
            return false;
        else
            return true;
    }
}