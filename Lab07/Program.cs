class Triangle: IComparable
{
    private double sideA;
    private double sideB;
    private double sideC;

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

    public (double A, double B, double C) GetSides()
    {

        (double A, double B, double C) sides = (A: sideA, B: sideB, C: sideC);
        return sides;
    }
    int IComparable.CompareTo(object obj)
    {
        Triangle it = (Triangle)obj;
        if (it.GetArea() == this.GetArea())
        {
            return 0;
        }
        else if (it.GetArea() > this.GetArea())
            {
                return 1;
            }
        else
        {
            return 0;
        }
    }
}
class Program
{
    public static void Main()
    {

        Triangle t1 = new();
        Triangle t2 = new();
        Triangle t3 = new();

        t1.CreateTriangle();
        Console.WriteLine("First traingle sides set");
        t2.CreateTriangle();    
        Console.WriteLine("Second traingle sides set");
        t3.CreateTriangle();
        Console.WriteLine("Third traingle sides set");

        Triangle[] triangles = {t1, t2, t3};
        Array.Sort(triangles);

        foreach (Triangle i in triangles) 
        {
            Console.WriteLine("Side A: {0}, Side B: {1}, Side C: {2}, Area: {3}", i.GetSides().A, i.GetSides().B, i.GetSides().C, i.GetArea());
        }
    }
}