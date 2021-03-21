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
        public static bool CheckTemperature(float TemperatureValue, string Language)
        {
            if (Language == "German")
            {
                BatteryOk = BatteryFactor.CheckBatteryStatus("Temperatur", MinTemperatureLimit, MaxTemperatureLimit, TemperatureValue);
            }
            if (Language == "English")
            {
                BatteryOk = BatteryFactor.CheckBatteryStatus("Temperature", MinTemperatureLimit, MaxTemperatureLimit, TemperatureValue);
            }
            return BatteryOk;
        }
    }
}
