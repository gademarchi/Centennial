using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Gabriel De Marchi
 * Date: July 11, 2017
 * Description: This is the Abstract Human class
 * Version: 0.2 - Added Abstract method DisplaySkills
 */

namespace COMP123_week10
{
    /// <summary>
    /// This is the Abstract Human Class
    /// </summary>
    public abstract class Human
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _name;
        private string _category;

        // PUBLIC PROPERTIES
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

        public string Category
        {

            get
            {
                return this._category;
            }

            set
            {
                this._category = value;
            }
        }

        // CONSTRUCTORS ---------------------------------------------

        /// <summary>
        /// This is the main constructor for the Human class.
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name, string category)
        {
            this.Name = name;
            this.Category = category;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS

        // PUBLIC ABSTRACT METHODS
        public abstract void DisplaySkills();

    }
}