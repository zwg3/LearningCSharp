class Program
{
    public static double Calc(double a, double b, double c, ref double x1, ref double x2)
    {
        double d = (b * b) - (4 * a * c);
        if (d < 0)
        {
            return -1;
        }
        else if (d == 0)
        {
            x1 = -b / (2 * a);
            x2 = x1;
            return 0;
        }
        else
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return 1;
        }
    }

    public static void Main()
    {
        double x1 = 0;
        double x2 = 0;
        Console.Write("Please enter the first coeficient: ");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the second coeficient: ");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the third coeficient: ");
        double c = Convert.ToInt32(Console.ReadLine());


        if (Calc(a, b, c, ref x1, ref x2) == -1)
        {
            Console.WriteLine("There were no roots found using the following coeficients: a = {0}, b = {1}, c = {2}", a, b, c);
        }
        else if (Calc(a, b, c, ref x1, ref x2) == 0)
        {
            Console.WriteLine("One root was found using the following coeficients: a = {0}, b = {1}, c = {2}, x1 = {3} = x2 = {4}", a, b, c, x1, x2);
        }
        else
        {
            Console.WriteLine("Two roots were found using the following coeficients: a = {0}, b = {1}, c = {2}, x1 = {3}, x2 = {4}", a, b, c, x1, x2);
        }
    }
}