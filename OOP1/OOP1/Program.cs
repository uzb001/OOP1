namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Oybek";
            student.RollNumber = "TM222-003";
            student.Marks = new int[] {1,2,3,4,5,6,7,1};
            student.DisplayInfo();
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public int[] Marks { get; set; }
        public double CalculateAvarage()
        {
            double sum = 0, counter = 0;
            for(int i = 0; i < Marks.Length; i++)
            {
                sum+= Marks[i];
                counter++;
            }
            return sum / counter;
        }

        public void DisplayInfo() 
        {
            Console.WriteLine($"Name: {Name}, RollNumber: {RollNumber}, AvarageMarks: {CalculateAvarage()}");
        }

    }
}