using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryStatusDisplay
    {
        public class German
        {
            public static string BatteryOK = "Die Batterie ist ok!";
            public static string BatteryFaulty = "Batterie ist fehlerhaft!";
            public static string BatteryFactors = "Batteriefaktoren";
            public static string MaximumLimit = " ist außerhalb des Bereichs und hat seinen maximalen Schwellenwert überschritten!";
            public static string MinimumLimit = " ist außerhalb des Bereichs und hat seinen Mindestschwellenwert fehlgeschlagen!";
            public static string MaxWarningLimit = " nähert sich seiner maximalen Schwelle!";
            public static string MinWarningLimit = " nähert sich der minimalen Schwelle!";
            public static string NormalLimit = " ist in der angegebenen Grenze!";
        }

        public class English
        {
            public static string BatteryOK = "Battery is OK!";
            public static string BatteryFaulty = "Battery is faulty!";
            public static string BatteryFactors = "Battery Factors";
            public static string MaximumLimit = " out of range and has exceeded its maximum threshold!";
            public static string MinimumLimit = " out of range and has failed its minimum threshold!";
            public static string MaxWarningLimit = " is approaching its maximum threshold!";
            public static string MinWarningLimit = " approaching its minimum threshold!";
            public static string NormalLimit = " in the specified limit!";
        }

        public static void PrintMessageGerman(List<string> BatteryLimit, string message)
        {
            if(BatteryLimit.Count != 0)
            {
                Console.WriteLine(German.BatteryFactors + ": " + $"{ string.Join(", ", BatteryLimit)}" + message);
            }
        }
        public static void PrintMessageEnglish(List<string> BatteryLimit, string message)
        {
            if (BatteryLimit.Count != 0)
            {
                Console.WriteLine(English.BatteryFactors + ": " + $"{ string.Join(", ", BatteryLimit)}" + message);
            }
        }
    }
}
