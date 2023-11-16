class AreaCalculator
{
    static void Main()
    {
        Console.WriteLine("Please input the equilateral triangle perimeter");
        double perimeter = Convert.ToDouble(Console.ReadLine());
        double side = perimeter / 3;
        double pHalved = perimeter / 2;
        double result = Math.Sqrt(pHalved * Math.Pow((pHalved - side), 3));
        Console.WriteLine("Side:\t\tArea:\n" + "{0:0.00}\t\t{1:0.00}", side, result);
    }
}