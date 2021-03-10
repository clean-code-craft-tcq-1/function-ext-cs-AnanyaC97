using System;
using System.Diagnostics;

namespace BatteryManagement
{
    public class BatteryCheckerFactors
    {
        public static void batteryIsOk(float Temperature, float StateOfCharge, float ChargeRate, string Language)
        {
            bool optimumTemperatureLimit = BatteryTemperature.CheckTemperature(Temperature, Language);
            bool optimumStateOfCharge = BatteryStateOfCharge.CheckStateOfCharge(StateOfCharge, Language);
            bool optimumChargeRate = BatteryChargeRate.CheckChargeRate(ChargeRate, Language);
            if (optimumTemperatureLimit && optimumStateOfCharge && optimumChargeRate)
                Console.WriteLine("Battery is ok!\nDie Batterie ist ok!\n");
            else
                Console.WriteLine("Battery is faulty!\nBatterie ist fehlerhaft!\n");
        }
        public static int Main()
        {
            batteryIsOk(25, 70, 0.7f, "English");
            batteryIsOk(25, 70, 0.7f, "German");
            batteryIsOk(50, 85, 0.0f, "English");
            batteryIsOk(-50, 10, 0.9f, "German");
            batteryIsOk(30, 100, 0.0f, "English");
            return 0;
        }
    }
}