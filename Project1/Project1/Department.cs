using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Department
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public List<Course> Courses { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Student> Students { get; set; }

        public Department (string Name,string Code) 
        {
            this.Name = Name;
            this.Code = Code;
            Courses = new List<Course> ();
            Professors = new List<Professor> ();
            Students = new List<Student> ();

        }

        public void AddCourses (Course course)
        {
            Courses.Add (course);
        }

        public List<Course> GetCourses()
        { 
            return Courses;
        }

        public void AddProfessors(Professor professor) 
        {
            Professors.Add (professor);
        }

        public List<Professor> GetProfessors() 
        { 
            return Professors; 
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public static implicit operator Department(List<Department> v)
        {
            throw new NotImplementedException();
        }
    }
}
