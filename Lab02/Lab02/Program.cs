public struct Distance
{
    public int inch;
    public int foot;   
}

class Program
{
    static void Main()
    {
        Distance firstSegment;
        Distance secondSegment;
        Distance thirdSegment;

        Console.WriteLine("Please input the first segment data");
        int firstData = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second segment data");
        int secondData = int.Parse(Console.ReadLine());

        firstSegment.foot = firstData / 12;
        firstSegment.inch = firstData % 12;
        secondSegment.foot = secondData / 12;
        secondSegment.inch = secondData % 12;

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