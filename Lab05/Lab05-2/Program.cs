﻿class ArrayCalc
{
    private static double[] Input()
    {
        Console.Write("Please specify the amount of numbers you would like to process: ");
        int size = int.Parse(Console.ReadLine());
        double[] numsArray = new double[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Please enter numbers one by one: ");
            numsArray[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        return numsArray;
    }

    private static void OutputArray(double[] numsArray)

    {
        Console.WriteLine("The entered numbers are: " + string.Join(" ", numsArray));
    }

    private static void OutputSum(double result)

    {
        Console.WriteLine("The sum of entered numbers is: {0:0.00}", result);
        
    }

    private static void OutputAverage(double result)
    {
        Console.WriteLine("The average of entered numbers is: {0:0.00}", result);
    }

    private static void OutputPosNegSum((double posSum, double negSum) result)

    {
        Console.WriteLine("The sum of positive numbers is:  {0:0.00}\n" +
                          "The sum of negative numbers is: {1:0.00}"
                          , result.posSum, result.negSum);
    }

    private static void OutputEvenOddSum((double, double) result)

    {
        Console.WriteLine("The sum of even numbers is: {0:0.00}\n" +
                          "The sum of odd numbers is: {1:0.00}"
                          , result.Item1, result.Item2);
    }

    private static void OutputMinMax((int minIndex, int maxIndex, double min, double max) result)

    {
        Console.WriteLine("The index of the maximal value number is: {0}\n" +
                          "The index of the minimal value number is: {1}"
                          , result.maxIndex, result.minIndex);
    }

    private static void OutputMultiplyBetween((double multiplyResult, int minIndex, int maxIndex, double minValue, double maxValue) result)

    {

        Console.WriteLine("The minimal value is {0:0.00} with an index of {1}\n" +
            "The maximal value is {2:0.00} with an index of {3}\n" +
            "The miltiplication of the numbers in between of them results in {4:0.00}",
            result.minValue, result.minIndex-1, result.maxValue, result.maxIndex, result.multiplyResult);
    }
    private static double Sum(double[] numsArray)
    {
        double result =0;

        foreach (double i in numsArray)
        {
            result += i;
        }
        return result;
    }

    private static double Average(double[] numsArray)
    {
        double result = 0;
        
        foreach(double i in numsArray)
        {
            result += i / numsArray.Length;
        }
        return result;
    }

    private static (double posSum, double negSum) PosNegSum(double[] numsArray)
    {
        
        double posSum = 0;
        double negSum = 0;

        foreach (double i in numsArray)
        {
            if (i >= 0)
            {
                posSum += i;
            }
            else
            {
                negSum += i;
            }            
        }
        (double posSum, double negSum) result = (posSum, negSum);
        return result;
    }

    private static (double, double) EvenOddSum(double[] numsArray)
    {

        double evenSum = 0;
        double oddSum = 0;

        foreach (double i in numsArray)
        {
            if (i % 2 == 0)
            {
                evenSum += i;
            }
            else
            {
                oddSum += i;
            }
        }
        var result = (evenSum, oddSum);
        return result;
    }

    private static (int minIndex, int maxIndex, double min, double max) MinMax(double[] numsArray)
    {
        double min = numsArray[0];
        double max = numsArray[0];

        foreach (double i in numsArray)
        {
            if (i <= min)
            {
                min = i;
            }
            else
            {
                max = i;
            }
        }

        int minIndex = Array.IndexOf(numsArray, min);
        int maxIndex = Array.IndexOf(numsArray, max);

        (int minIndex, int maxIndex, double min, double max) result = (minIndex, maxIndex, min, max);

        return result;
    }

    private static (double multiplyResult, int minIndex, int maxIndex, double minValue, double maxValue) MultiplyBetween(
        (int minIndex, int maxIndex, double min, double max) minMaxTuple, double[]numsArray)
    {
        double multiplyResult = 1;
        int minIndex = minMaxTuple.minIndex + 1;
        int maxIndex = minMaxTuple.maxIndex;
        double minValue = minMaxTuple.min;
        double maxValue = minMaxTuple.max;
        Range range = minIndex..maxIndex;

        foreach (int i in numsArray[range])
        {
            multiplyResult *= i;
        }
        (double multiplyResult, int minIndex, int maxIndex, double minValue, double maxValue) result = (multiplyResult, minIndex, maxIndex, minValue, maxValue);

        return result;
    }

    public static int Prompter(double[] numsArray)
    {
        Console.WriteLine("Please select the operation you would like to perform");
        Console.WriteLine(
            "1 - find the sum of the entered numbers\n" +
            "2 - find the average of the entered numbers\n" +
            "3 - find the separate sum of positive and negative numbers entered\n" +
            "4 - find the separate sum of even and odd numbers entered\n" +
            "5 - find the indices if minmal and maximal values entered\n" +
            "6 - find the multiplication value of items located between minimal and maximal values entered"
            );
        int prompt = int.Parse(Console.ReadLine());
        
        return prompt;
    }

public static void Main()
    {
        double[] numsArray = Input();

        int select = Prompter(numsArray);

        switch (select)
        {
            case 1:
                OutputSum(Sum(numsArray)); 
                break;
            case 2:
                OutputAverage(Average(numsArray));
                break;
            case 3:
                OutputPosNegSum(PosNegSum(numsArray));
                break;
            case 4:
                OutputEvenOddSum(EvenOddSum(numsArray));
                break;
            case 5:
                OutputMinMax(MinMax(numsArray));
                break;
            case 6:
                OutputMultiplyBetween(MultiplyBetween(MinMax(numsArray), numsArray));
                break;
            default:
                break;
        }       
    }
}

