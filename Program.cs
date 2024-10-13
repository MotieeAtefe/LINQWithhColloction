using System.Collections.Generic;
namespace LINQWithhColloction
{
    internal class Program
    {
        static List<Student> student = new List<Student>();
        static void Main(string[] args)
        {
            
        }
        static void AddStudent()
        {
            Console.Write("Id:");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age:");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("Department: ");
            string department = Console.ReadLine();
            Student newStudent = new Student()
            {
                Name = name,
                Id = id,
                Age = Age,
                Department = department
            };
            student.Add(newStudent);
        }
            
    }
}