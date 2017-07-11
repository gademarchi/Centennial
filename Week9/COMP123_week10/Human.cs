using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_week10
{
    /// <summary>
    /// This is the human abstract class
    /// </summary>
    public abstract class Human
    {
        //public fields
        private string _name;


        //public properities
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }

        }
        

       //constructors
       /// <summary>
       /// This is the constructor
       /// </summary>

        public Human()
        {
            this.Name = name;

        }



    }
}