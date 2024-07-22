using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class University
    {
       public string Name {  get; set; }
       public string Location { get; set; }

        public List<Department> departments { get; set; }

       public University(String name,String location) 
        {
            Name = name;
            Location = location;
        }

        public void AddDepartment (Department dep)
        {
            departments.Add(dep);
        }

        public List<Department> GetDepartments() 
        {
            return departments;
        }
    }
}
