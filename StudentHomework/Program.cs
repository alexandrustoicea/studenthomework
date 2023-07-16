namespace StudentHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());

            Student student = new Student(name, age);

            Console.WriteLine(student.Info);
        }
    }
}