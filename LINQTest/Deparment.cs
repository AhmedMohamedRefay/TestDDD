using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    public class Deparment
    {
        public Deparment(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Deparment()
        {
            
        }
        public int Id {  get; set; }
        public string Name { get; set; }

    }
}
