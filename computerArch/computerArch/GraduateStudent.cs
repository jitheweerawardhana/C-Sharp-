using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computerArch
{
    public class GraduateStudent: Student
    {
        public string ReaserchTopic { get; set; }

        public GraduateStudent(string name,string major,string id, string topic):base(name, major, id)
        {
            ReaserchTopic = topic;
        }

        public void ApplyForTA()
        {
            Console.WriteLine("Apply for ta");
        }
    }

}
