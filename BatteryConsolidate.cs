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
            if (MinimumLimit.Count != 0)
            {
                BatteryStatusDisplay.PrintMinimumLimit();
                MinimumLimit.Clear();
            }
            if (MinWarning.Count != 0)
            {
                BatteryStatusDisplay.PrintMinimumWarning();
                MinWarning.Clear();
            }
            if (MaximumLimit.Count != 0)
            {
                BatteryStatusDisplay.PrintMaximumLimit();
                MaximumLimit.Clear();
            }
            if (MaxWarning.Count != 0)
            {
                BatteryStatusDisplay.PrintMaximumWarning();
                MaxWarning.Clear();
            }
            if (NormalLimit.Count != 0)
            {
                BatteryStatusDisplay.PrintValid();
                NormalLimit.Clear();
            }
        }
    }
}
