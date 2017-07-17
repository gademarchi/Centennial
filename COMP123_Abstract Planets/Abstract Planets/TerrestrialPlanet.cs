using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Planets
{
    class TerrestrialPlanet : Planet
    {
        //Private Instances Variables
        private bool _oxygen;

        //constructors
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name,diameter,mass)
        {
            this._oxygen = oxygen;
        }




    }
}