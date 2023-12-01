namespace Lab09
{

    class Rectangle : Shape, IRotate
    {
        private (double x, double y) verticeA { get; set; }
        private (double x, double y) verticeB { get; set; }
        private (double x, double y) verticeC { get; set; }
        private (double x, double y) verticeD { get; set; }
        private (double x, double y) Center { get; set; }

        public Rectangle((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d) 
        {
            this.verticeA = a;
            this.verticeB = b;
            this.verticeC = c;
            this.verticeD = d;
        }
        public override string ToString()
        {
            return $"Rectangle data: Vertice A - {verticeA}\tVertice B - {verticeB}\tVertice C - {verticeC}\tVertice D - {verticeD}\t";
        }

        public (double width, double height) GetSides()
        {
            double width = Math.Abs(verticeB.x - verticeA.x);
            double height = Math.Abs(verticeB.y - verticeD.y);

            return new(width, height);
        }

        public override double GetPerimeter()
        {
            (double width, double height) param = GetSides();
            return 2 * (param.width + param.height);

        }

        public override double GetArea()
        {
            (double width, double height) param = GetSides();
            return param.width * param.height;
        }

        public void GetCenter()
        {
            Center = ((verticeA.x + verticeB.x + verticeC.x + verticeD.x) / 4, (verticeA.y + verticeB.y + verticeC.y + verticeD.y) / 4);
        }

        public void Rotate(int angle)
        {
            Console.WriteLine("The rectangle has been rotated {0} degrees\n", angle);
        }

        public override string  IsValid()
        {
            List<double> vertices = [verticeA.x, verticeA.y, verticeB.x, verticeB.y, verticeC.x, verticeC.y, verticeD.x, verticeD.y];

            string result = "valid";

            foreach (double v in vertices) 
            {
                if (v <= 0)
                {
                    result = "not valid";
                    return result;
                }
            }
            return result;
        }
    }
}
