class Triangle
{
    public double sideA;
    public double sideB;
    public double sideC;
    public Triangle GetTriangle()
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

    public void GetPerimeter(Triangle data)
    {
        double result = data.sideA + data.sideB + data.sideC;
        Console.WriteLine("The perimeter is: {0:0.00}", result);
    }
    public void GetArea(Triangle data)
    {
        double p = (data.sideA + data.sideB + data.sideC) / 2;
        double result = Math.Sqrt(p * (p - data.sideA) * (p - data.sideB) * (p - data.sideC));
        Console.WriteLine("The area is: {0:0.00}", result);
    }
    public void IsTriangle(Triangle data)
    {

        if (data.sideA + data.sideB <= data.sideC || data.sideA + data.sideC <= data.sideB || data.sideB + data.sideC <= data.sideA)
            Console.WriteLine("This is not a triangle!");
        else
            Console.WriteLine("This is a triangle!");
    }
    public void PrintSides(Triangle data)
    {
        Console.WriteLine("Side A is: {0:0.00}\nSide B is: {0:0.00}\nSide C is: {0:0.00}\n", data.sideA, data.sideB, data.sideC);
    }
}
class Program
{
    public static void Main()
    {
        Triangle created = new();

        Triangle data = created.GetTriangle();
        created.IsTriangle(data);
        created.GetPerimeter(data);
        created.GetArea(data);
        created.PrintSides(data);

    }
}