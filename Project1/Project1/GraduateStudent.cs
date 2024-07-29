using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class GraduateStudent:Student
    {
        private static string studentId;

        public string ResearchTopic { get; set; }

        public GraduateStudent(String name, String studentID , String major , String researchTopic):base( name,studentId,major)
        {
            ResearchTopic = researchTopic ;
        }

        public void ApplyForTA()
        {
            Console.WriteLine("Applyed For TA");
        }
    }
}
