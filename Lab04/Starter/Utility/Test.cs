public class Test
{
	public static void Main()
	{
        Console.Write("Enter the first number: ");
        int x = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int y = Int32.Parse(Console.ReadLine());
		int greater = Utils.Greater(x, y);
		
		Console.WriteLine("The greater value is: {0}", greater);

		Console.WriteLine("Before Swap: {0}, {1}", x, y);
		Utils.Swap(ref x, ref y);
        Console.WriteLine("After Swap: {0}, {1}", x, y);

		bool ok = false;
		int f;
		Console.Write("Number for factorial: ");
		x = Int32.Parse(Console.ReadLine());
		ok = Utils.Factorial(x, out f);
		if (ok) 
		{
			Console.WriteLine("Factorial = {0}", f);
		}
        else
        {
			Console.WriteLine("Cannot compute factorial");
        }

    }
}
