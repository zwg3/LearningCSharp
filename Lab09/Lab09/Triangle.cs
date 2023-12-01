
namespace Lab09
{
    class Triangle : Shape, IRotate

    {
        private (double x, double y) verticeA { get; set; } 
        private (double x, double y) verticeB { get; set; }
        private (double x, double y) verticeC { get; set; }

        public Triangle((double x, double y) a, (double x, double y) b, (double x, double y) c)
        {
            this.verticeA = a;
            this.verticeB = b;
            this.verticeC = c;
        }
                
        public override string ToString()
        {
            return $"Triangle data: Verticle A - {verticeA}\tVerticle B - {verticeB}\tVertice C - {verticeC}\t";
        }

        public (double sideA, double sideB, double sideC) GetSides()
        {
            double sideA = Math.Sqrt(Math.Pow(verticeA.x - verticeB.x, 2) + Math.Pow(verticeA.y - verticeB.y, 2));
            double sideB = Math.Sqrt(Math.Pow(verticeA.x - verticeC.x, 2) + Math.Pow(verticeA.y - verticeC.y, 2));
            double sideC = Math.Sqrt(Math.Pow(verticeB.x - verticeC.x, 2) + Math.Pow(verticeB.y - verticeC.y, 2));

            return new(sideA, sideB, sideC);
        }

        public override double GetPerimeter()
        {
            (double sideA, double sideB, double sideC) sides = GetSides();
            return sides.sideA + sides.sideB + sides.sideC;
        }
        public override double GetArea()
        {
            return (verticeA.x * (verticeB.y - verticeC.y) + verticeB.x*(verticeC.y - verticeA.y) + verticeC.x*(verticeA.y - verticeB.y))/2;
        }
        public void Rotate(int angle)
        {
            Console.WriteLine("The triangle has been rotated {0} degrees\n", angle);
        }
        public override string IsValid()
        {
            (double sideA, double sideB, double sideC) sides = GetSides();

            bool res = (sides.sideA + sides.sideB > sides.sideC) &&
                       (sides.sideA + sides.sideC > sides.sideB) &&
                       (sides.sideC + sides.sideB > sides.sideA);

            if (res)
            {
                return "valid";
            }
            return "not valid";
        }

    }
}
