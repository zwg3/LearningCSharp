class Triangle : IComparable
{
    private double sideA;
    private double sideB;
    private double sideC;

    public void CreateTriangle(double length)
    {
        sideA = sideB = sideC = length;
    }

    public void CreateTriangle(double a, double b, double c)
    {
        sideA = a;
        sideB = b;
        sideC = c;
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

        t1.CreateTriangle(3);
        t2.CreateTriangle(3,4,5);
        t3.CreateTriangle(10,4,9);

        Triangle[] triangles = { t1, t2, t3 };
        Array.Sort(triangles);

        foreach (Triangle i in triangles)
        {
            Console.WriteLine("Side A: {0:0.000}, Side B: {1:0.000}, Side C: {2:0.000}, Area: {3:0.000}", i.GetSides().A, i.GetSides().B, i.GetSides().C, i.GetArea());
        }
    }
}