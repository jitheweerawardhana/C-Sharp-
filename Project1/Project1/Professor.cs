using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Professor
    {
        public string Name { get; set; }
        public string ProfessorID { get; set; }
        public string Specialization { get; set; }

        public List<Course> courses { get; set; }

        public Professor(string name,string profId,string spec) 
        {
            Name = name;
            ProfessorID = profId;
            Specialization = spec;
        }

        public void AddCourse(Course course) 
        {
            courses.Add(course);
        }

        public List <Course> GetCourses() 
        {
            return courses;
        }


    }
}
