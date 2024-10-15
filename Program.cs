using System.Collections.Generic;
namespace LINQWithhColloction
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Univercity Student Manager");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayAllStudent();
                        break;


                }
            }
            
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
            students.Add(newStudent);
            Console.WriteLine("Student added successfully!\n");

            static void DisplayAllStudent()
            {
                if (students.Any())
                {
                    Console.WriteLine("\n show all Student");
                    var studentQuery = from student in students select student;
                    foreach (var student in studentQuery)
                    {
                        Console.WriteLine($"Id: {student.Id}\n,Name: {student.Name}\n,Age: {student.Age}\n, ");
                    }
                    
                }
                else
                {
                    Console.WriteLine("\n not found ");
                }
            }

        }
            
    }
}