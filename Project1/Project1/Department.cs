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
        public List<Professor> Processors { get; set; }
        public List<Student> Students { get; set; }

        public Department (string Name,string Code) 
        {
            this.Name = Name;
            this.Code = Code;
        }
    }
}
