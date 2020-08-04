/*
    In this file we write the first assignment for the C# course from Pirple.
    The requirements is using variables of all types to describe an animal, and write them to the console
*/

using System;

namespace Assignment_1
{
    
    public class Program
    {
        public static void Main(string[] args)
        {

            string commonName = "Blue Whale";
            string species = "Balaenoptera musculus";
            bool isAquatic = true;

            uint lifeSpanInYears = 63;
            float lengthInMeters = 21;
            float weightInTons = 153;

            double populationCount = 20000;
            byte vocalizationMinimumFrequencyHz = 14;
            byte vocalizationMaximumFrequencyHz = 222;

            Console.WriteLine("The chosen animal's common name is " + commonName);
            Console.WriteLine("The animal's species if officially named: " + species);
            Console.WriteLine("Is it aquatic? " + isAquatic);

            Console.WriteLine("A blue whale live arounds " + lifeSpanInYears + " years");
            Console.WriteLine("It has a length of " + lengthInMeters + " meters.");
            Console.WriteLine("And weighs around " + weightInTons + " tons");

            Console.WriteLine("Worldwide, the blue whale population is extimated at around " + populationCount + " specimens.");
            Console.WriteLine("Their song are well known, with frequencies of down to " + vocalizationMinimumFrequencyHz + "Hz");
            Console.WriteLine("But the sounds are oscilating up to " + vocalizationMaximumFrequencyHz + "Hz");
        }
    }
}