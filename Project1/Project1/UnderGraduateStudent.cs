using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class UnderGraduateStudent:Student
    {
        public int Year {  get; set; }

        public UnderGraduateStudent(string name, string major, string id, int year) : base(name, major, id)
        {
            this.Year = year;
        }

        public void DeclareMajor(string major)
        {
            Major = major;
        }

    }
}
