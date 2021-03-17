using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryConsolidate
    {
        public static List<string> MaximumLimit = new List<string>();
        public static List<string> MinimumLimit = new List<string>();
        public static List<string> MaxWarning = new List<string>();
        public static List<string> MinWarning = new List<string>();
        public static List<string> NormalLimit = new List<string>();

        public static void DisplayBatteryStatus()
        {
            DisplayBatteryBreachStatus();
            DisplayWarningStatus();
            if (NormalLimit.Count != 0)
                BatteryStatusDisplay.PrintValid();
            ClearList();
        }
        public static void DisplayBatteryBreachStatus()
        {
            if (MinimumLimit.Count != 0)
                BatteryStatusDisplay.PrintMinimumLimit();
            if (MaximumLimit.Count != 0)
                BatteryStatusDisplay.PrintMaximumLimit();
        }
        public static void DisplayWarningStatus()
        {
            if (MinWarning.Count != 0)
                BatteryStatusDisplay.PrintMinimumWarning();
            if (MaxWarning.Count != 0)
                BatteryStatusDisplay.PrintMaximumWarning();
        }
        public static void ClearList()
        {
            MinimumLimit.Clear();
            MinWarning.Clear();
            MaximumLimit.Clear();
            MaxWarning.Clear();
            NormalLimit.Clear();
        }
    }
}
