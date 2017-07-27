﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Abubakir Myrzaly
 * StudentID: 300931945
 * Date: July 23, 2017
 * Description: This is the GiantPlanet class which is subclass of derive class. 
 * The class will also implement both the IHasMoons and IHasRings interfaces.
 * Version: 0.5 - Made changes in interface (still doesn't work)
 */

namespace Assignment_4
{
    public class GiantPlanet : Planet ,IHasMoons , IHasRings
    {
        // PRIVATE INSTANCE VARIABLES

        private string _type;

        // PUBLIC PROPERTIES

        public bool HasMoons
        {
            get
            {
                if (MoonCount > 0)
                {
                    return true;
                }
                else return false;
            }

            set
            {
                this._type = value;
            }
        }

        public bool HasRings
        {
            get
            {
                if (RingCount > 0)
                {
                    return true;
                }
                else return false;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        // CONSTRUCTORS

        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name,diameter,mass)
        {
            this._type = type;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}