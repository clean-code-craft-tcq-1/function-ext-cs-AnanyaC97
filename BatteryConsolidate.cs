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

        public static void DisplayBatteryStatus(string language)
        {
            if (language == "German")
            {
                BatteryStatusDisplay.PrintMessageGerman(MinimumLimit, BatteryStatusDisplay.German.MinimumLimit);
                BatteryStatusDisplay.PrintMessageGerman(MaximumLimit, BatteryStatusDisplay.German.MaximumLimit);
                BatteryStatusDisplay.PrintMessageGerman(MinWarning, BatteryStatusDisplay.German.MinWarningLimit);
                BatteryStatusDisplay.PrintMessageGerman(MaxWarning, BatteryStatusDisplay.German.MaxWarningLimit);
                BatteryStatusDisplay.PrintMessageGerman(NormalLimit, BatteryStatusDisplay.German.NormalLimit);
            }
            if (language == "English")
            {
                BatteryStatusDisplay.PrintMessageEnglish(MinimumLimit, BatteryStatusDisplay.English.MinimumLimit);
                BatteryStatusDisplay.PrintMessageEnglish(MaximumLimit, BatteryStatusDisplay.English.MaximumLimit);
                BatteryStatusDisplay.PrintMessageEnglish(MinWarning, BatteryStatusDisplay.English.MinWarningLimit);
                BatteryStatusDisplay.PrintMessageEnglish(MaxWarning, BatteryStatusDisplay.English.MaxWarningLimit);
                BatteryStatusDisplay.PrintMessageEnglish(NormalLimit, BatteryStatusDisplay.English.NormalLimit);
            }
            ClearList();
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
