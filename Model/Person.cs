using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvancedAssignment1.Model
{
    internal class Person
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (17 < value && value < 100)
                {
                    _age = value;
                }
            }
        }

    }
}
