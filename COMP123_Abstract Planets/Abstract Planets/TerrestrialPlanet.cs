﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Gabriel De Marchi
 * Date: July 17, 2017
 * Version: 0.1 - Create TerrestrialPlanet
 */

namespace Abstract_Planets
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        //Private Instances Variables
        private bool _oxygen;

        //constructors
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) 
            : base(name,diameter,mass)
        {
            this._oxygen = oxygen;
        }

        //public method
        public bool Habitable()
        {
           if(_oxygen == true)
            {
                _oxygen = true;
            }
            else
            {
                _oxygen = false;
            }
            return _oxygen;

        }

        public bool HasMoons()
        {
            bool moon;

            if (MoonCount > 0)
            {
                moon = true;
            }
            else
            {
                moon = false;
            }
            return moon;
        }



    }
}