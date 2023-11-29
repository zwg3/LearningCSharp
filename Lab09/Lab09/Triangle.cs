
namespace Lab09
{
    class Triangle : Shape

    {
        private Shape[] vertices;

        public Triangle(Shape a, Shape b, Shape c) : base((a.xVal + b.xVal + c.xVal), (a.yVal + b.yVal + c.yVal))

        {
            vertices = new Shape[3];
            vertices[0] = a;
            vertices[1] = b;
            vertices[2] = c;
        }
        public void PrintTriangle()
        {
            Console.WriteLine("Vertices:");
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i].PrintCoordinate();
            }
        }
        public Triangle BuildTriangle()
        {
            Shape a = new(1, 2);
            Shape b = new(2, 3);
            Shape c = new(3, 4);

            Triangle t = new(a, b, c);
            return t;        
        }
    }
}
