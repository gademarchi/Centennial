using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Gabriel De Marchi
 * Date: July 13, 2017
 * Description: This Interface lists the signature for any Super Villain Subclass
 * Version: 0.1 - declared the Darma property
 */

namespace COMP123_week10
{

    public interface IHasDarma
    {
        // PUBLIC PROPERTIES
        int Darma { get; set; }
    }
}