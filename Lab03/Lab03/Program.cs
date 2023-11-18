﻿class Marksman
{
    static void Main()
    {
        Random randNum = new Random();
        int targetX = randNum.Next(-50, 50);
        int targetY = randNum.Next(-50, 50);
        

        int highScoreMargin = 10;
        int midScoreMargin = 20;
        int lowScoreMargin = 30;

        var shots = new List<Tuple<double, double>>();

        int finalScore = 0;


        Console.WriteLine("Please enter how many rounds you would like to play for");
        short rounds = short.Parse(Console.ReadLine());

        while (rounds > 0)
        {
            int difficultyScore = randNum.Next(0, 5);
            Console.WriteLine("Current difficulty bonus: {0}", difficultyScore);
            Console.Write("Take your shot (X axis) ");
            double shotX = double.Parse(Console.ReadLine());
            Console.Write("Take your shot (Y axis) ");
            double shotY = double.Parse(Console.ReadLine());

            shots.Add(Tuple.Create(shotX, shotY));

            double distance = Math.Sqrt(Math.Pow(shotX - targetX, 2) + Math.Pow(shotY - targetY, 2));
            double result = distance + difficultyScore;
            Console.WriteLine(distance);
            Console.WriteLine(result);

            if (result <= highScoreMargin) 
            {
                Console.WriteLine("HIGHSCORE!");
                finalScore += 14 + Math.Abs(difficultyScore);
            }
            else if (result <= midScoreMargin) 
            {
                Console.WriteLine("MIDSCORE");
                finalScore += 7 + Math.Abs(difficultyScore);
            }
            else if (result <= lowScoreMargin)
            {
                Console.WriteLine("LOWSCORE");
                finalScore += 3 + Math.Abs(difficultyScore);
            }
            else
            {
                Console.WriteLine("MISS");
            }
            rounds -= 1;
        }
        Console.WriteLine("Target was located at: X = {0} Y = {1}", targetX, targetY);
        Console.WriteLine("Final score: {0}", finalScore);
        Console.WriteLine("Shots taken: " + string.Join(", ", shots));
    }
}