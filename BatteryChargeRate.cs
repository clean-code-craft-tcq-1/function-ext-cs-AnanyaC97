using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryChargeRate
    {
        public static float MinChargeRate = 0.5f;
        public static float MaxChargeRate = 0.8f;
        public static bool BatteryOk;
        public static bool CheckChargeRate(float ChargeRateValue, string Language)
        {
            if (Language == "German")
            {
                BatteryOk = BatteryFactor.CheckBatteryStatus("Ladestrom", MinChargeRate, MaxChargeRate, ChargeRateValue);
            }
            if (Language == "English")
            {
                BatteryOk = BatteryFactor.CheckBatteryStatus("Charge Rate", MinChargeRate, MaxChargeRate, ChargeRateValue);
            }
            return BatteryOk;
        }
    }
}
