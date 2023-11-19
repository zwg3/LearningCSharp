public struct Distance
{
    public int inch, foot, data;
}

class Program
{
    static void Main()
    {
        Distance firstSegment, secondSegment, thirdSegment;

        Console.WriteLine("Please input the first segment data");
        firstSegment.data = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second segment data");
        secondSegment.data = int.Parse(Console.ReadLine());

        firstSegment.foot = firstSegment.data / 12;
        firstSegment.inch = firstSegment.data % 12;
        secondSegment.foot = secondSegment.data / 12;
        secondSegment.inch = secondSegment.data % 12;

        thirdSegment.foot = firstSegment.foot + secondSegment.foot;
        thirdSegment.inch = firstSegment.inch + secondSegment.inch;

        if (thirdSegment.inch > 12)
        {
            thirdSegment.foot++;
            thirdSegment.inch %= 12;
        }

        else{}

        Console.WriteLine("The sum of both segments is: {0} '- {1}", thirdSegment.foot, thirdSegment.inch);
    }
}