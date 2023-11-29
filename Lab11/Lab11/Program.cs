
public class Distance
{
    public int Feet { get; set; }
    public double Inches { get; set; }
    public Distance()
    {
        Feet = 0;
        Inches = 0;
    }
    public Distance(int feet, double inches)
    {
        Feet = feet;
        Inches = inches;
    }

    public static Distance operator + (Distance d1, Distance d2)
    {
        int totalFeet = d1.Feet + d2.Feet;
        double totalInches = d1.Inches + d2.Inches;

        if (totalInches >= 12)
        {
            totalInches -= 12;
            totalFeet++;
        }
        return new Distance(totalFeet, totalInches);
    }


    public static Distance operator - (Distance d1, Distance d2)
    {
        int totalFeet = d1.Feet - d2.Feet;
        double totalInches = d1.Inches - d2.Inches;

        if (totalInches < 0)
        {
            totalInches += 12;
            totalFeet--;
        }

        return new Distance(totalFeet, totalInches);
    }
    public static bool operator == (Distance d1, Distance d2)
    {
        return d1.Feet == d2.Feet && d1.Inches == d2.Inches;
    }

    public static bool operator > (Distance d1, Distance d2)
    {
        return (d1.Feet > d2.Feet) || (d1.Feet == d2.Feet && d1.Inches > d2.Inches);
    }

    public static bool operator < (Distance d1, Distance d2)
    {
        return (d1.Feet < d2.Feet) || (d1.Feet == d2.Feet && d1.Inches < d2.Inches);
    }

    public static bool operator !=(Distance d1, Distance d2)
    {
        return !(d1 == d2);
    }

    public override string ToString()
    {        
        return $"{Feet}-'{Inches}";
    }
}
public class Program
{
    public static void Main()
    {
        Distance d1 = new(8, 1);
        Distance d2 = new(7, 4);
        Distance d3 = d1 + d2;
        Distance d4 = d1 - d2;

        Console.WriteLine(d3);
        Console.WriteLine(d4);
        Console.WriteLine(d4 > d3);
        Console.WriteLine(d4 < d3);
    }
}