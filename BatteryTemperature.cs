using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryTemperature
    {
        public static float MinTemperatureLimit = 0;
        public static float MaxTemperatureLimit = 45;
        public static bool BatteryOk;
        public static bool CheckTemperature(float TemperatureValue)
        {
            if (BatteryCheckerFactors.GermanLanguage)
            {
                BatteryOk = BatteryFactor.CheckBatteryStatus("Temperatur", MinTemperatureLimit, MaxTemperatureLimit, TemperatureValue);
            }
            else
            {
                BatteryOk = BatteryFactor.CheckBatteryStatus("Temperature", MinTemperatureLimit, MaxTemperatureLimit, TemperatureValue);
            }
            return BatteryOk;
        }
    }
}
