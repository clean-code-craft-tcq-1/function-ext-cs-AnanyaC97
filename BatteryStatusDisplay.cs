using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryStatusDisplay
    {
        public static void PrintMaximumLimit()
        {
            if (BatteryCheckerFactors.GermanLanguage)
                Console.WriteLine($"Batteriefaktoren: {string.Join(",", BatteryConsolidate.MaximumLimit)} ist außerhalb des Bereichs und hat seinen maximalen Schwellenwert überschritten!");
            else
                Console.WriteLine($"Battery Factors: {string.Join(",", BatteryConsolidate.MaximumLimit)} out of range and has exceeded its maximum threshold!");
        }
        public static void PrintMinimumLimit()
        {
            if (BatteryCheckerFactors.GermanLanguage)
                Console.WriteLine($"Batteriefaktoren: {string.Join(", ", BatteryConsolidate.MinimumLimit)} ist außerhalb des Bereichs und hat seinen Mindestschwellenwert fehlgeschlagen!");
            else
                Console.WriteLine($"Battery Factors: {string.Join(", ", BatteryConsolidate.MinimumLimit)} out of range and has failed its minimum threshold!");
        }
        public static void PrintMinimumWarning()
        {
            if (BatteryCheckerFactors.GermanLanguage)
                Console.WriteLine($"Warnung! Batteriefaktoren: {string.Join(", ", BatteryConsolidate.MinWarning)} nähert sich der minimalen Schwelle!");
            else
                Console.WriteLine($"Warning! Battery Factors: {string.Join(", ", BatteryConsolidate.MinWarning)} approaching its minimum threshold!");
        }
        public static void PrintMaximumWarning()
        {
            if (BatteryCheckerFactors.GermanLanguage)
                Console.WriteLine($"Warnung! Batteriefaktoren: {string.Join(", ", BatteryConsolidate.MinWarning)} nähert sich seiner maximalen Schwelle!");
            else
                Console.WriteLine($"Warning! Battery Factor: {string.Join(", ", BatteryConsolidate.MinWarning)} is approaching its maximum threshold!");
        }
        public static void PrintValid()
        {
            if (BatteryCheckerFactors.GermanLanguage)
                Console.WriteLine($"Batteriefaktoren: {string.Join(", ", BatteryConsolidate.NormalLimit)} ist in der angegebenen Grenze!");
            else
                Console.WriteLine($"Battery Factor: {string.Join(", ", BatteryConsolidate.NormalLimit)} in the specified limit!");

        }
    }
}
