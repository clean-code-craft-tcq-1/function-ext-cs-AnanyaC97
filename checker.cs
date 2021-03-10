using System;
using System.Diagnostics;

namespace BatteryManagement
{
    public class BatteryCheckerFactors
    {
        public static bool batteryIsOk(float Temperature, float StateOfCharge, float ChargeRate, string Language)
        {
            bool optimumTemperatureLimit = BatteryTemperature.CheckTemperature(Temperature, Language);
            bool optimumStateOfCharge = BatteryStateOfCharge.CheckStateOfCharge(StateOfCharge, Language);
            bool optimumChargeRate = BatteryChargeRate.CheckChargeRate(ChargeRate, Language);
            if (optimumTemperatureLimit && optimumStateOfCharge && optimumChargeRate)
            {
                Console.WriteLine("Battery is ok!\nDie Batterie ist ok!\n"); return true;
            }
            else
            {
                Console.WriteLine("Battery is faulty!\nBatterie ist fehlerhaft!\n"); return false;
            }
        }
        public static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false");
                Environment.Exit(1);
            }
            Console.WriteLine();
        }
        public static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                Console.WriteLine("Expected false, but got true");
                Environment.Exit(1);
            }
            Console.WriteLine();
        }
        public static int Main()
        {
            ExpectTrue(batteryIsOk(25, 70, 0.7f, "English"));
            ExpectTrue(batteryIsOk(25, 70, 0.7f, "German"));
            ExpectFalse(batteryIsOk(50, 85, 0.0f, "English"));
            ExpectFalse(batteryIsOk(-50, 10, 0.9f, "German"));
            ExpectFalse(batteryIsOk(30, 100, 0.0f, "English"));
            return 0;
        }
    }
}