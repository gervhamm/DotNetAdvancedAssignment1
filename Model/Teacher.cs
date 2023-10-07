using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedAssignment1.Model
{
    internal class Teacher : Person
    {
        public string[] courses {  get; set; }
        public Teacher() { 
            courses = new string[2];
        }

    }
}
