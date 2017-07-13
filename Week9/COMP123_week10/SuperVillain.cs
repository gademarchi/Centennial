using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 13, 2017
 * Description: This is the SuperHero class which inherits from the SuperHuman class
 * Version: 0.1 - implemented the ToString method of the superhuman class
 */

namespace COMP123_week10
{
    /// <summary>
    /// This is the SuperHero class
    /// </summary>
    public class SuperVillain : SuperHuman, IHasDarma
    {
        // PRIVATE INSTANCE VARIABLES
        private int _darma;

        // PUBLIC PROPERTIES
        public int Darma
        {
            get
            {
                return this._darma;
            }

            set
            {
                this._darma = value;
            }
        }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperVillain class
        /// It takes two arguments - name (string) - darma (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="darma"></param>
        public SuperVillain(string name, int darma)
            : base(name)
        {
            this.Darma = darma;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}