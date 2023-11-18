public struct Dictance
{
    public int varA;
    public int varB;
    public int varC;
}

class Program
{
    static void Main()
    {
        Dictance calc;

        Console.WriteLine("Please input the first distance parameter");
        calc.varA = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please input the second distance parameter");
        calc.varB = Int32.Parse(Console.ReadLine());
        calc.varC = calc.varA + calc.varB;

        int feet = (int)calc.varC / 12;
        int inches = (int)calc.varC % 12;

        Console.WriteLine("The calculated distance is {0} '- {1}", feet, inches);
    }


}