using System;
using System.Diagnostics;

namespace BatteryManagement
{
    public class BatteryCheckerFactors
    {
        public static bool BatteryChecker(float Temperature, float StateOfCharge, float ChargeRate, string language)
        {
            bool optimumTemperatureLimit = BatteryTemperature.CheckTemperature(Temperature, language);
            bool optimumStateOfCharge = BatteryStateOfCharge.CheckStateOfCharge(StateOfCharge, language);
            bool optimumChargeRate = BatteryChargeRate.CheckChargeRate(ChargeRate, language);
            BatteryConsolidate.DisplayBatteryStatus(language);
            return optimumTemperatureLimit && optimumStateOfCharge && optimumChargeRate;
        }
        public static void DisplayBatteryStatusGerman(bool BatteryStatus)
        {
            if (BatteryStatus)
                Console.WriteLine(BatteryStatusDisplay.German.BatteryOK + "\n");
            else
                Console.WriteLine(BatteryStatusDisplay.German.BatteryFaulty + "\n");
        }
        public static void DisplayBatteryStatusEnglish(bool BatteryStatus)
        {
            if (BatteryStatus)
                Console.WriteLine(BatteryStatusDisplay.English.BatteryOK + "\n");
            else
                Console.WriteLine(BatteryStatusDisplay.English.BatteryFaulty + "\n");
        }
        public static int Main()
        {
            DisplayBatteryStatusEnglish(BatteryChecker(25, 70, 0.7f, "English"));
            DisplayBatteryStatusEnglish(BatteryChecker(1, 19, 0.0f, "English"));
            DisplayBatteryStatusGerman(BatteryChecker(30, 100, 0.0f, "German"));
            DisplayBatteryStatusGerman(BatteryChecker(-50, 10, 0.9f, "German"));
            return 0;
        }
    }
}
