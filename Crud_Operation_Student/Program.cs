using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Operation_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCrud crud = new StudentCrud();

            try
            {
                string ch;
                do
                {
                    Console.WriteLine("1.Add Student Info");
                    Console.WriteLine("2.Display all student Info");
                    Console.WriteLine("3.Change Info");
                    Console.WriteLine("4.Get student Info by ID");
                    Console.WriteLine("5. Delete student Info");
                    Console.WriteLine("-------------------------------------------");

                    Console.WriteLine("Enter your choise :");

                    int op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Student s1 = new Student();
                            Console.WriteLine("Enter Student ID :");
                            s1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Student Name :");
                            s1.Name = (Console.ReadLine());
                            Console.WriteLine("Enter percentage");
                            s1.Percentage = Convert.ToInt32(Console.ReadLine());
                            crud.AddStudent(s1);
                            Console.WriteLine("Student Info added Successfully");
                            break;
                        case 2:
                            List<Student> s2 = crud.DisplayStudent();
                            foreach (Student stud in s2)
                            {
                                Console.WriteLine(stud);
                            }
                            break;
                        case 3:
                            Student s=new Student();
                            Console.WriteLine("Enter student id :");
                            s.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            s.Name = (Console.ReadLine());
                            Console.WriteLine("Enter percentage");
                            s.Percentage = Convert.ToInt32(Console.ReadLine());
                            crud.UpdateStudent(s);
                            Console.WriteLine("Update Info Successfully");
                            break;
                        case 4:
                            Console.WriteLine("ENter student id :");
                            int id=Convert.ToInt32(Console.ReadLine());
                            Student s3 =crud.GetStudentById(id);
                            Console.WriteLine(s3);
                            break;
                       case 5:
                            Console.WriteLine("Enter student id that you want to delete");
                            int id1=Convert.ToInt32(Console.ReadLine());
                            crud.DeleteStudent(id1);
                            Console.WriteLine("Delete student Info successfully");
                            break;
                        default:
                            Console.WriteLine("Wrong Input !");
                            break;
                    }
                    Console.WriteLine("Do you want to continue ! (y/n)");
                    ch = Console.ReadLine();
                } while (ch == "y" | ch == "yes");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
