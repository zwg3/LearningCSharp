class Program
{
    public static (double, double, double) Calc (double a, double b, double c)
    {            
        double d = (b * b) - (4 * a * c);
        double x1 = 0;
        double x2 = 0;
        double flag;

        if (d < 0)
        {
            flag = -1;

        }
        else if (d == 0)
        {
            flag = 0;
            x1 = -b / (2 * a);
            x2 = x1;

        }
        else
        {
            flag = 1;
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);

        }

        var result = (x1, x2, flag);

        return result;
    }
    
    public static void Main()
    {

        Console.Write("Please enter the first coeficient: ");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the second coeficient: ");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the third coeficient: ");
        double c = Convert.ToInt32(Console.ReadLine());

        var result = Calc(a, b, c);

        if (result.Item3 == -1)
        {
            Console.WriteLine("There were no roots found using the following coeficients: a = {0}, b = {1}, c = {2}", a, b, c);
        }
        else if (result.Item3 == 0)
        {
            Console.WriteLine("One root was found using the following coeficients: a = {0}, b = {1}, c = {2}, x = {3}", a, b, c, result.Item1);
        }
        else
        {
            Console.WriteLine("Two roots were found using the following coeficients: a = {0}, b = {1}, c = {2}, x1 = {3}, x2 = {4}", a, b, c, result.Item1, result.Item2);
        }
    }
}
