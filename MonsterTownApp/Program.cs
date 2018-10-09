using System;
using static System.Console;

namespace MonsterTownApp
{
    class Program
    {
        static void Main(string[] args)
        {

            

            string createName;
            Console.WriteLine("Please name your town: ");
            createName = Console.ReadLine();
            

            int createPopulation;
            Console.WriteLine("Please enter town population: ");
            createPopulation = int.Parse(Console.ReadLine());
            


            int createStopLights;
            Console.WriteLine("Please enter number of Stoplights in town: ");
            createStopLights = int.Parse(Console.ReadLine());


            Console.WriteLine("Your town is named " + createName + ". It has a population of " + createPopulation + " and " + createStopLights + " stoplights.");

            MonsterTownLib.Town userTown;

            userTown = new MonsterTownLib.Town(createName, createPopulation, createStopLights);

           // MonsterTownLib.Vampire newVampire;

            //newVampire = new MonsterTownLib.Vampire("Steve");

            

            //WriteLine($"{}")

        }
    }
}
