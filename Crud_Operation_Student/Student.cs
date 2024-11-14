using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Operation_Student
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Percentage}";
        }
    }

    public class StudentCrud
    {
        List<Student> students = new List<Student>();

        public StudentCrud()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }
        public List<Student> DisplayStudent()
        {
            return students;
        }

        public void UpdateStudent(Student s)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == s.Id)
                {
                    students[i].Id = s.Id;
                    students[i].Name = s.Name;
                    students[i].Percentage = s.Percentage;
                    break;
                }
            }
        }

        public void DeleteStudent(int id)
        {
            for (int i = 0; i < students.Count; i++) 
            {
                if (students[i].Id == id)
                {
                    students.RemoveAt(i);
                    break;
                }
            }
        }

        public Student GetStudentById(int id)
        {
            Student s=new Student();
            foreach (Student student in students)
            {
                if (student.Id == id)
                {
                    s.Id = student.Id;
                    s.Name = student.Name;
                    s.Percentage = student.Percentage;
                }
            }
            return s;
        }
    }
}
