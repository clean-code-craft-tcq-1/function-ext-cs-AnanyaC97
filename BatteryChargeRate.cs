using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryChargeRate
    {
        public static float MinChargeRate = 0.5f;
        public static float MaxChargeRate = 0.8f;
        public static float MinChargeRateWarning = (float)(MinChargeRate + (0.05 * MaxChargeRate));
        public static float MaxChargeRateWarning = (float)(MaxChargeRate - (0.05 * MaxChargeRate));
        public static bool BatteryOk;

        public static bool CheckChargeRate(float ChargeRateValue, string BatteryLanguage)
        {
            if (BatteryLanguage == "English")
                BatteryOk = BatteryFactor.CheckBatteryCondition("Charge Rate", MinChargeRate, MinChargeRateWarning, MaxChargeRate, MaxChargeRateWarning, ChargeRateValue, BatteryLanguage);
            else
                BatteryOk = BatteryFactor.CheckBatteryCondition("Ladestrom", MinChargeRate, MinChargeRateWarning, MaxChargeRate, MaxChargeRateWarning, ChargeRateValue, BatteryLanguage);
            return BatteryOk;
        }
    }
}
