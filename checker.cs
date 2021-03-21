using System;
using System.Diagnostics;

namespace BatteryManagement
{
    public class BatteryCheckerFactors
    {
        public static void BatteryChecker(float Temperature, float StateOfCharge, float ChargeRate, string language)
        {
            bool optimumTemperatureLimit = BatteryTemperature.CheckTemperature(Temperature, language);
            bool optimumStateOfCharge = BatteryStateOfCharge.CheckStateOfCharge(StateOfCharge, language);
            bool optimumChargeRate = BatteryChargeRate.CheckChargeRate(ChargeRate, language);
            BatteryConsolidate.DisplayBatteryStatus(language);
            bool BatteryStatus = optimumTemperatureLimit && optimumStateOfCharge && optimumChargeRate;
            if (BatteryStatus)
                BatteryOk(language);
            else
                BatteryFaulty(language);
        }
        public static void DisplayMessageGerman(object BatteryState)
        {
            Console.WriteLine(BatteryState + "\n");
        }

        public static void DisplayMessageEnglish(object BatteryState)
        {
            Console.WriteLine(BatteryState + "\n");
        }
        public static void BatteryFaulty(string language)
        {
            if (language == "German")
                DisplayMessageGerman(BatteryStatusDisplay.German.BatteryFaulty);
            if (language == "English")
                DisplayMessageEnglish(BatteryStatusDisplay.English.BatteryFaulty);
        }
        public static void BatteryOk(string language)
        {
            if (language == "German")
                DisplayMessageGerman(BatteryStatusDisplay.German.BatteryOK);
            if (language == "English")
                DisplayMessageEnglish(BatteryStatusDisplay.English.BatteryOK);
        }
        public static int Main()
        {
            BatteryChecker(25, 70, 0.7f, "English");
            BatteryChecker(1, 19, 0.0f, "English");
            BatteryChecker(30, 100, 0.0f, "German");
            BatteryChecker(-50, 10, 0.9f, "German");
            return 0;
        }
    }
}