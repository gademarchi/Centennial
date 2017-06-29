using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    /// <summary>
    /// This is the Student class
    /// </summary>
    class Student : Person
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _studentID;

        // PUBLIC PROPERTIES
        public string StudentID
        {
            get
            {
                return this._studentID;
            }

            set
            {
                this._studentID = value;
            }
        }

        // CONSTRUCTORS -----------------------------------------

        /// <summary>
        /// This is the constructor for the Student class. It takes three arguments
        /// name (string) - age (int) and studentID (string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name, int age, string studentID)
            : base(name, age)
        {
            this.StudentID = studentID;
        }

        // PUBLIC METHODS ------------------------------------------

        /// <summary>
        /// This is the Studies Method. Takes no arguments
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name + " is Studying!");
        }

    }
}