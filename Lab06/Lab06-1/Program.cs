class Triangle
{
    public double sideA;
    public double sideB;
    public double sideC;
    public void GetTriangle()
    {

        Console.Write("Please enter side A: ");
        sideA = double.Parse(Console.ReadLine());
        Console.Write("Please enter side B: ");
        sideB = double.Parse(Console.ReadLine());
        Console.Write("Please enter side C: ");
        sideC = double.Parse(Console.ReadLine());
    }
    public void GetPerimeter()
    {
        double result = sideA + sideB + sideC;
        Console.WriteLine("The perimeter is: {0:0.00}", result);
    }
    public void GetArea()
    {
        double p = (sideA + sideB + sideC) / 2;
        double result = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        Console.WriteLine("The area is: {0:0.00}", result);
    }
    public void IsTriangle()
    {

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            Console.WriteLine("This is not a triangle!");
        else
            Console.WriteLine("This is a triangle!");
    }
    public void PrintSides()
    {
        Console.WriteLine("Side A is: {0:0.00}\nSide B is: {0:0.00}\nSide C is: {0:0.00}\n", sideA, sideB, sideC);
    }
}
class Program
{
    public static void Main()
    {
        Triangle created = new();

        created.GetTriangle();        

        created.IsTriangle();
        created.GetPerimeter();
        created.GetArea();
        created.PrintSides();
    }
}