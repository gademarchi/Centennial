using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Press any key to close.");

            if (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }


        }
    }
}


    

