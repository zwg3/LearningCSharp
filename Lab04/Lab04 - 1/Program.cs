using System.Reflection.Metadata;

class Operation
{
    private static bool IsTriangle(double a, double b, double c)
    {
        bool ok;

        if (a <= b + c || b <= a + c || c <= a + b)
        {
            ok = true;
        }
        else
        {
            ok = false;
        }

        return ok;
    }
    public static double CalcArea(double sideA, double sideB, double sideC)
    {


        if (IsTriangle(sideA, sideB, sideC))
        {
            double pHalved = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(pHalved * (pHalved - sideA) * (pHalved - sideB) * (pHalved - sideC));
            return area;
        }
        else
        {
            return 0;
        }           
    }

    public static double CalcArea(double side)
    {
        double perimeter = side * 3;
        double pHalved = perimeter / 2;

        return Math.Sqrt(pHalved * Math.Pow((pHalved - side), 3));
    }

    public static void Main()
    {
        int step = 0;
        while (step < 1)
        {
            Console.Write("Please specify whether your triangle is equilateral (y/n): ");
            bool isEquilateral = false;
            string input = Console.ReadLine();
            if (input == "y")
            {
                isEquilateral = true;
            }
            else if (input == "n")
            {
            }
            else
            {
                Console.WriteLine("Incorrect input");
                break;
            }

            double answer;

            if (isEquilateral)
            {
                Console.Write("Please enter a triangle side value: ");
                double a = double.Parse(Console.ReadLine());
                answer = CalcArea(a);
            }
            else
            {
                Console.Write("Please enter first triangle side value: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Please enter second triangle side value: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Please enter second triangle side value: ");
                double c = double.Parse(Console.ReadLine());
                answer = CalcArea(a, b, c);
            }
            Console.WriteLine("The triangle area  is: {0}.", answer);
            step++;
        }
        
    }
}