using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Gabriel De Marchi
 * Date: July 26, 2017 
 * Version: 0.2 - create WaitForAnyKey() method.
 * GitHub Link:
 * https://github.com/gademarchi/Centennial/tree/master/COMP123_Abstract%C2%A0Planets
 * 
 */


namespace Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {



            GiantPlanet myGiantPlanet = new GiantPlanet("Jupiter", 139822, 317.8, "Gas");
            Console.WriteLine(myGiantPlanet.ToString()); // displays details of myGiantPlanet

            TerrestrialPlanet myTerrestrialPlanet = new TerrestrialPlanet("Earth", 12104, 5.972, true);
            Console.WriteLine(myTerrestrialPlanet.ToString()); // displays details of myTerrestrialPlanet

            WaitForAnyKey();
        }

         static void WaitForAnyKey()
        {
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }


        }
    }
}


    

