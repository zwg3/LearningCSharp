class AreaCalculator
{
    static void Main()
    {
        double p, side, pHalved, result;

        Console.WriteLine("Please input the equilateral triangle perimeter");
        p = Convert.ToDouble(Console.ReadLine());
        side = p / 3;
        pHalved = p / 2;
        result = Math.Sqrt(pHalved * (pHalved - side) * (pHalved - side) * (pHalved - side));
        Console.WriteLine("Side:\t\tArea:\n" + "{0:0.00}\t\t{1:0.00}", side, result);
    }
}