using SecondEntityFramework.DAL;
using SecondEntityFramework.Models;
using System.Xml.Serialization;

namespace SecondEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using TestDbContext dbContext = new TestDbContext();
            int choice = 0;

            do
            {

                Console.WriteLine("Main Menu :");
                Console.WriteLine(" 1. View All Students");
                Console.WriteLine(" 2. Insert a Student");
                Console.WriteLine(" 3. Update a Student by ID");
                Console.WriteLine(" 4. Delete a Student by ID");
                Console.WriteLine(" 5. Exit");
                Console.WriteLine("Enter your Choice");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1: List<Student> slist = dbContext.students.ToList();

                        foreach (Student s in slist)
                        {
                            Console.WriteLine($"id: {s.StudentID}  name: {s.StudentName} marks: {s.StudentMarks} admission date: {s.StudentAdmissionDate}");

                        }

                        break;

                    case 2:

                        Student newStudent = new Student();

                        Console.WriteLine("Enter  Name: ");
                        newStudent.StudentName=Console.ReadLine();

                        Console.WriteLine("Enter  Marks: ");
                        newStudent.StudentMarks = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter  Admission Date: DD/MM/YYYY");
                        newStudent.StudentAdmissionDate = Convert.ToDateTime(Console.ReadLine());


                        dbContext.students.Add(newStudent);
                        dbContext.SaveChanges();
                        break;

                    case 3:
                        Console.WriteLine("Enter Student ID to update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());

                        Student studentToUpdate = dbContext.students.Find(updateId);

                        if (studentToUpdate != null)
                        {
                            Console.WriteLine("Enter New Name: ");
                            studentToUpdate.StudentName = Console.ReadLine();

                            Console.WriteLine("Enter New Marks: ");
                            studentToUpdate.StudentMarks = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter New Admission Date: DD/MM/YYYY");
                            studentToUpdate.StudentAdmissionDate = Convert.ToDateTime(Console.ReadLine());

                            dbContext.SaveChanges();
                            Console.WriteLine("Student updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Student not found!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter Student ID to delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());

                        Student studentToDelete = dbContext.students.Find(deleteId);

                        if (studentToDelete != null)
                        {
                            dbContext.students.Remove(studentToDelete);
                            dbContext.SaveChanges();
                            Console.WriteLine("Student deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Student not found!");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exiting Program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;


                }
            } while (choice != 5);

        }
    }
}
