namespace Lab09
{
    class Circle: Shape

    {
        private (double x, double y) Center;
        private (double x, double y) Point;

        public Circle((double x, double y) center, (double x, double y) point)
        {
            Center = center;
            Point = point;
        }
        public double GetRadius()
        {
            return Math.Sqrt(Math.Pow(Point.x - Center.x, 2) + Math.Pow(Point.y - Center.y, 2));
            
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(GetRadius(), 2);
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * GetRadius();
        }
        public override string ToString()
        {
            return $"Circle data: Point A - {Center}\tPoint B - {Point}";
        }

        public override string IsValid()
        {
            if (GetRadius() <= 0)
            {
                return "not valid";
            }
            return "valid";
        }
    }
}
