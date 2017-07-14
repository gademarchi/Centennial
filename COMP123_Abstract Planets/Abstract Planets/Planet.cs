using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Gabriel De Marchi
 * Date: July 13,2017
 * version: 0.1 - Create Planet class
 */

namespace Abstract_Planets
{
    public abstract class Planet
    {


        //Private Instance Variables
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //Public Properties
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
            set
            {
                this._diameter = value;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
            set
            {
                this._mass = value;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
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
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //Constructor
        public Planet(string name, double diameter, double mass)
        {
            this.Name = name;
            this.Diameter = diameter;
            this.Mass = mass;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}