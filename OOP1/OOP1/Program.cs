namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 6);
            Console.WriteLine("Perimetr: " + rectangle.CalculatePerimetr());
            Console.WriteLine("Area: " + rectangle.CalculateArea());
            Console.WriteLine("Diagonal: " + rectangle.CalculateDiagonal());

            Circle circle = new Circle(3);
            Console.WriteLine("Length: " +  circle.CalculateLength());
            Console.WriteLine("Area: " +  circle.CalculateArea());
        }
    }
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() 
        {
            Width = 0;
            Height = 0;
        }
        public Rectangle(double width, double height) 
        { 
            Width = width;
            Height = height;
        }


        public double CalculatePerimetr()
        {
            return (Width + Height) * 2;
        }
        public double CalculateArea()
        {
            return Width * Height;
        }
        public double CalculateDiagonal()
        {
            return  Math.Sqrt(Width * Width + Height * Height);
        }
    }

    class Circle
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateLength()
        {
            return 2 * Math.PI * Radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}