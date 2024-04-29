using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    public  class Student
    {
       
        public Student()
        {
            
        }

        public Student(string name, string department, int age, int departmentId)
        {
            Name = name;
            Department = department;
            Age = age;
            DepartmentId = departmentId;
        }

        public string Name { get; set; }
        public string Department { set; get; }

        public int Age {  get; set; }

        public int DepartmentId { get; set; }
    }
}
