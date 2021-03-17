using System;
using System.Diagnostics;

namespace BatteryManagement
{
    public class BatteryCheckerFactors
    {
        public static bool GermanLanguage = false;

        public static bool batteryIsOk(float Temperature, float StateOfCharge, float ChargeRate)
        {
            bool optimumTemperatureLimit = BatteryTemperature.CheckTemperature(Temperature);
            bool optimumStateOfCharge = BatteryStateOfCharge.CheckStateOfCharge(StateOfCharge);
            bool optimumChargeRate = BatteryChargeRate.CheckChargeRate(ChargeRate);
            BatteryConsolidate.DisplayBatteryStatus();
            return optimumTemperatureLimit && optimumStateOfCharge && optimumChargeRate;
        }
        public static void DisplayMessage(bool BatteryOK)
        {
            if(BatteryOK)
                Console.WriteLine("Battery is ok! Die Batterie ist ok!\n");
            else
                Console.WriteLine("Battery is faulty! Batterie ist fehlerhaft!\n");
        }
        public static int Main()
        {
            DisplayMessage(batteryIsOk(25, 70, 0.7f));
            DisplayMessage(batteryIsOk(1, 19, 0.0f));
            GermanLanguage = true;
            DisplayMessage(batteryIsOk(30, 100, 0.0f));
            DisplayMessage(batteryIsOk(-50, 10, 0.9f));
            return 0;
        }
    }
}