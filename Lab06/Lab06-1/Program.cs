class Triangle
{
    public double sideA;
    public double sideB;
    public double sideC;
}

class Program { 
    public static void Main()
    {
        Triangle triangle  = GetTriangle();

        if (IsTriangle(triangle) == true)
        {
            Console.WriteLine("This is a triangle!");
            Console.WriteLine("The perimeter is: {0:0.00}", GetPerimeter(triangle));
            Console.WriteLine("The area is: {0:0.00}", GetArea(triangle));
            Console.WriteLine("Side A is: {0:0.00}\nSide B is: {0:0.00}\nSide C is: {0:0.00}\n", triangle.sideA, triangle.sideB, triangle.sideC);
        }
        else
        {
            Console.WriteLine("This is not a triangle!");
        }
    }

    public static Triangle GetTriangle()
    {
        Triangle created = new();

        Console.Write("Please enter side A: ");
        created.sideA = double.Parse(Console.ReadLine());
        Console.Write("Please enter side B: ");
        created.sideB = double.Parse(Console.ReadLine());
        Console.Write("Please enter side C: ");
        created.sideC = double.Parse(Console.ReadLine());

        return created;
    }

    public static double GetPerimeter(Triangle data)
    {
        return data.sideA + data.sideB + data.sideC;
    }

    public static double GetArea(Triangle data)
    {
        double p = GetPerimeter(data) / 2;
        return Math.Sqrt(p * (p - data.sideA) * (p - data.sideB) * (p - data.sideC));
    }

    public static bool IsTriangle(Triangle data)
    {

        if (data.sideA + data.sideB <= data.sideC || data.sideA + data.sideC <= data.sideB || data.sideB + data.sideC <= data.sideA)
            return false;
        else
            return true;
    }
}