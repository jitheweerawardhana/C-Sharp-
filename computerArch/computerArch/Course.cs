using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computerArch
{
    public class Course
    {
        public string Title {  get; set; }
        public string CourseId { get; set; }
        public int Credits { get; set; }
        public List<Student> Students { get; set; }
        public List<Professor> professors { get; set; }

        public Course(string title,string id, int credits)
        {
            Title = title;
            CourseId = id;
            Credits = credits;
            Students = new List<Student>();
            professors = new List<Professor>();
        }

        public void EnrollStudent(Student student)
        {
            Students.Add(student);
        }

        public List<Student> GetStudents()
        {

        return Students; 
        }

        public void SetProfessor(Professor professor)
        {
            professors.Add(professor);
        }

        public List<Professor> GetProfessors()
        {
            return professors;
        }
    
    }
}
