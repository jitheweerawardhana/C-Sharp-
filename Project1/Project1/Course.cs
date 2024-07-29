using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Course
    {
        public string Title { get; set; }
        public string CourseId { get; set; }
        public int Credits { get; set; }

        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }

        public Course(String title, String courseID, int credits)
        {
            Title = title;
            CourseId = courseID;
            Credits = credits;
            Students = new List<Student>();
            Professors = new List<Professor>();
        }
        public void EnrolStudent(Student student)
        {
            Students.Add(student);
        }
        public List<Student>GetStudent()
        { return Students; }

        public void SetProfessor(Professor professor)
        {
            Professors.Add(professor);
        }
        public List< Professor>GetProfessors()
            { 
                 return Professors; 
        }
    }
}
