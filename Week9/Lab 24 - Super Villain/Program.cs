using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Gabriel De Marchi
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.5 - implemented the ToString method of the superhuman class
 */

namespace COMP123_week10
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Super Dude", 20,"Hero");
            superHero.AddPower("Spider Climbing", 70);
            superHero.AddPower("Webcasting", 40);
            Console.WriteLine(superHero.ToString());

            SuperVillain superVillain = new SuperVillain("Joker", 30,"Villain");
            superVillain.AddPower("High intelligence", 50);
            superVillain.AddPower("Skilled chemist", 40);
            Console.WriteLine(superVillain.ToString());
            


        }
    }



}