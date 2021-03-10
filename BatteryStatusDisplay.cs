using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryStatusDisplay
    {
        public static void PrintMaximumLimit(string BatteryState, float MaxBatteryValue, float BatteryValue, string BatteryLanguage)
        {
            if (BatteryLanguage == "English")
                Console.WriteLine("Battery Factor: {0} {1} is out of range and has exceeded its maximum threshold {2} !", BatteryState, BatteryValue, MaxBatteryValue);
            else
                Console.WriteLine("Batteriefaktor: {0} {1} ist außerhalb des Bereichs und hat seinen maximalen Schwellenwert überschritten {2} !", BatteryState, BatteryValue, MaxBatteryValue);
        }
        public static void PrintMinimumLimit(string BatteryState, float MinBatteryValue, float BatteryValue, string BatteryLanguage)
        {
            if (BatteryLanguage == "English")
                Console.WriteLine("Battery Factor: {0} {1} is out of range and has failed its minimum threshold {2} !", BatteryState, BatteryValue, MinBatteryValue);
            else
                Console.WriteLine("Batteriefaktor: {0} {1} ist außerhalb des Bereichs und hat seinen Mindestschwellenwert fehlgeschlagen {2} !", BatteryState, BatteryValue, MinBatteryValue);
        }
        public static void PrintMinimumWarning(string BatteryState, float MinBatteryWarning, float BatteryValue, string BatteryLanguage)
        {
            if (BatteryLanguage == "English")
                Console.WriteLine("Warning! Battery Factor: {0} {1} is approaching its minimum threshold {2} !", BatteryState, BatteryValue, MinBatteryWarning);
            else
                Console.WriteLine("Warnung! Batteriefaktor: {0} {1} nähert sich der minimalen Schwelle {2} !", BatteryState, BatteryValue, MinBatteryWarning);
        }
        public static void PrintMaximumWarning(string BatteryState, float MaxBatteryWarning, float BatteryValue, string BatteryLanguage)
        {
            if (BatteryLanguage == "English")
                Console.WriteLine("Warning! Battery Factor: {0} {1} is approaching its maximum threshold {2} !", BatteryState, BatteryValue, MaxBatteryWarning);
            else
                Console.WriteLine("Warnung! Batteriefaktor: {0} {1} nähert sich seiner maximalen Schwelle {2} !", BatteryState, BatteryValue, MaxBatteryWarning);
        }
        public static void PrintValid(string BatteryState, float BatteryValue, string BatteryLanguage)
        {
            if (BatteryLanguage == "English")
                Console.WriteLine("Battery Factor: " + BatteryState + " " + BatteryValue + " is in the specified limit !");
            else
                Console.WriteLine("Batteriefaktor: " + BatteryState + " " + BatteryValue + " ist in der angegebenen Grenze !");

        }
    }
}
