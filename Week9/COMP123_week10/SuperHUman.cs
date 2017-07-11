using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Gabriel De Marchi
 * Date: July 11,2017
 * Description: This is the SuperHUman sub class
 *
 */


namespace COMP123_week10
{
    /// <summary>
    /// This is the superHuman sub class.
    /// Its a inherits from the human superclass
    /// </summary>
    public class SuperHUman :Human
    {
        //private fields
        private List<Power> _powers;

        //private properties

        //constructors
        public SuperHUman(string name)
            :base(name)
        {

        }

        //public methids

        //private methods
        private void _initialize()
        {
            this._powers = new List<Power>();
        }


    }

}