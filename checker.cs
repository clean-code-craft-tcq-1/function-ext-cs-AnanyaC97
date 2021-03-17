using System;
using System.Diagnostics;

namespace BatteryManagement
{
    public class BatteryCheckerFactors
    {
        public static bool GermanLanguage = false;

        public static bool BatteryChecker(float Temperature, float StateOfCharge, float ChargeRate)
        {
            bool optimumTemperatureLimit = BatteryTemperature.CheckTemperature(Temperature);
            bool optimumStateOfCharge = BatteryStateOfCharge.CheckStateOfCharge(StateOfCharge);
            bool optimumChargeRate = BatteryChargeRate.CheckChargeRate(ChargeRate);
            BatteryConsolidate.DisplayBatteryStatus();
            return optimumTemperatureLimit && optimumStateOfCharge && optimumChargeRate;
        }
        public static void BatteryFaulty()
        {
            if (GermanLanguage)
                Console.WriteLine("Batterie ist fehlerhaft!\n");
            else
                Console.WriteLine("Battery is faulty!\n");
        }
        public static void BatteryOk()
        {
            if(GermanLanguage)
                Console.WriteLine("Die Batterie ist ok!\n");
            else
                Console.WriteLine("Battery is ok!\n");
        }
        public static void DisplayMessage(bool BatteryChecker)
        {
            if (BatteryChecker)
                BatteryOk();
            else
                BatteryFaulty();
        }
        public static int Main()
        {
            DisplayMessage(BatteryChecker(25, 70, 0.7f));
            DisplayMessage(BatteryChecker(1, 19, 0.0f));
            GermanLanguage = true;
            DisplayMessage(BatteryChecker(30, 100, 0.0f));
            DisplayMessage(BatteryChecker(-50, 10, 0.9f));
            return 0;
        }
    }
}
