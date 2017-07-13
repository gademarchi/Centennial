using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Gabriel De Marchi
 * Date: July 13, 2017
 * Description: This is the SuperVillain class which inherits from the SuperHuman class
 * Version: 0.1 - implemented the ToString method of the superhuman class
 */

namespace COMP123_week10
{
    /// <summary>
    /// This is the SuperHero class
    /// </summary>
    public class SuperVillain : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malice;

        // PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperVillain class
        /// It takes two arguments - name (string) - Malice (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="malice"></param>
        /// <param name="category"></param>
        public SuperVillain(string name, int malice, string category)
            : base(name, category)
        {
            this.Malice = malice;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}