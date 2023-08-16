namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 4;
            rectangle.DisplayInfo();
        }
    }
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculadeArea ()
        {
            return Width * Height;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Area of Rectangular: {CalculadeArea()}");
        }
    }
}