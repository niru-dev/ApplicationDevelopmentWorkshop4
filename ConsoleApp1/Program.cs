namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();
            student stud2 = new student();
            stud1.id = 1;
            stud1.name ="Neeruu";
            stud1.age = 21;

            stud2.id = 2;
            stud2.name ="Nishu";
            stud2.age = 15;
            student.college= "Itahari International";

            Console.WriteLine("student 1:");
            Console.WriteLine($"ID:{stud1.name}, Age: {stud1.age} college: {student.college}");
         



        }
    }
}
