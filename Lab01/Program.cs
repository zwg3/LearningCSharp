class AreaCalculator
{
    static void Main()
    {
        double perimeter, side, pHalved, result;
        Console.WriteLine("Please input the equilateral triangle perimeter");
        perimeter = Convert.ToDouble(Console.ReadLine());
        side = perimeter / 3;
        pHalved = perimeter / 2;
        result = Math.Sqrt(pHalved * Math.Pow((pHalved - side), 3));
        Console.WriteLine("Side:\t\tArea:\n" + "{0:0.00}\t\t{1:0.00}", side, result);
    }
}