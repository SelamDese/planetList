using System;
using System.Collections.Generic;

namespace planetlists
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary< string , List<string >> shelter = new Dictionary<string, List<string>>();
            
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
// Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
// Create another List that contains that last two planet of our solar system.
// Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, and Neptune. 
            List<string> lastTwoPlanetsList = new List<string>(){"Uranus", "Neptune"};
// Combine the two lists by using AddRange().
            planetList.AddRange(lastTwoPlanetsList);
// Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
// Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");
// Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets
// into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
             List<string> rockyPlanets = planetList.GetRange(0, 4);
            // foreach(string r in rockyPlanets)
            // {
            //     Console.WriteLine(r);
            // }
// Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");
            foreach(string planet in planetList)
            {
                Console.WriteLine(planet);
            } 

        }
    }
}