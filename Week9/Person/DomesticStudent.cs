using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person
{
    public class DomesticStudent : Student
    {
        // PUBLIC PROPERTIES

        public string DomesticAddress { get; set; }

        // CONSTRUCTORS ---------------------------

        public DomesticStudent(string name, int age, string studentID)
            : base(name, age, studentID)
        {
            this.DomesticAddress = "Unknown";
        }

    }
}