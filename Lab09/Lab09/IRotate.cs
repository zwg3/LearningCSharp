namespace Lab09
{
    interface IRotate
    {
        void Rotate(int angle)
        {
            Console.WriteLine("The object has been rotated {0} degrees\n", angle);
        }
    }
}
