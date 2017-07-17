using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Planets
{
     class GiantPlanet : Planet
    {
        //Private Instances variables
        private string _type;

    
        //Constructor Method
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter,mass)
        {
            this._type = type;

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

        public bool HasRings()
        {
            bool rings;
            if (RingCount > 0)
            {
                rings = true;
            }
            else
            {
                rings = false;
            }
            return rings;
        }
    }
}