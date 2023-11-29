
namespace Lab09
{
    class Shape
    {
        protected double x { get; set; }
        protected double y { get; set; }
        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double xVal
        {
            get { return x; }
            set { x = value; }
        }
        public double yVal
        {
            get { return y; }
            set { y = value; }
        }
        public void PrintCoordinate()
        {
            Console.WriteLine("X: " + xVal + " Y: " + yVal);

        }

    }
}
