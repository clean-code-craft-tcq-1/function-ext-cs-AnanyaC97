using System;
using System.Diagnostics;

namespace BatteryManagement
{
    public class BatteryCheckerFactors
    {
        public static bool GermanLanguage = false;

        public static void batteryIsOk(float Temperature, float StateOfCharge, float ChargeRate)
        {
            bool optimumTemperatureLimit = BatteryTemperature.CheckTemperature(Temperature);
            bool optimumStateOfCharge = BatteryStateOfCharge.CheckStateOfCharge(StateOfCharge);
            bool optimumChargeRate = BatteryChargeRate.CheckChargeRate(ChargeRate);
            if (optimumTemperatureLimit && optimumStateOfCharge && optimumChargeRate)
                Console.WriteLine("Battery is ok!\nDie Batterie ist ok!\n");
            else
                Console.WriteLine("Battery is faulty!\nBatterie ist fehlerhaft!\n");
        }
        public static int Main()
        {
            batteryIsOk(25, 70, 0.7f);
            batteryIsOk(50, 85, 0.0f);
            GermanLanguage = true;
            batteryIsOk(30, 100, 0.0f);
            batteryIsOk(-50, 10, 0.9f);
            return 0;
        }
    }
}