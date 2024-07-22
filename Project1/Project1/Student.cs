using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Student
    {
        public string Name { get; set; }
        public string StudentId { get; set; }
        public string Major { get; set; }

        public List<Course> courses { get; set; }

        public Student(string name,string id,string major) 
        {
            Name = name;
            StudentId = id;
            Major = major;
        }

        public void EntrolInCourse(Course course) 
        {
            courses.Add(course);
        }

        public List <Course> GetCourses() 
        {
            return courses;
        }
    }
}
