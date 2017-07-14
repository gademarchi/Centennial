using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Planets
{
    public class GiantPlanet : Planet
    {
        //Private Instances variables
        private string _type;

        //Public Instances
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        public GiantPlanet(string name, double diameter, double mass, string type)
        {

        }



    }
}