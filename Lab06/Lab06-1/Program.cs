using System.Reflection.Metadata.Ecma335;

class Triangle
{
    public double sideA;
    public double sideB;
    public double sideC;

    public void CreateTriangle()
    {
        Console.Write("Please enter side A: ");
        sideA = double.Parse(Console.ReadLine());
        Console.Write("Please enter side B: ");
        sideB = double.Parse(Console.ReadLine());
        Console.Write("Please enter side C: ");
        sideC = double.Parse(Console.ReadLine());
    }

    public double GetPerimeter()
    {
        double result = sideA + sideB + sideC;
        return result;
    }

    public double GetArea()
    {
        double p = (sideA + sideB + sideC) / 2;
        double result = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        return result;

    }

    public bool IsTriangle()
    {

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            return false;
        else
            return true;
    }
}
class Program
{
    public static void Main()
    {
        Triangle created = new();

        created.CreateTriangle();
        
        if (created.IsTriangle())
        {
            Console.WriteLine("This is a triangle!");
            Console.WriteLine("The perimeter is: {0:0.00}", created.GetPerimeter());
            Console.WriteLine("The area is: {0:0.00}", created.GetArea());
        }
        else
        {
            Console.WriteLine("This is not a triangle!");
        }

        Console.WriteLine("Side A is: {0:0.00}\nSide B is: {1:0.00}\nSide C is: {2:0.00}\n", created.sideA, created.sideB, created.sideC);

    }
}