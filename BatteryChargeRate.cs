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
        public static bool CheckChargeRate(float ChargeRateValue)
        {
            if (BatteryCheckerFactors.GermanLanguage)
            {
                BatteryOk = BatteryFactor.CheckMinimumWarningCondition("Ladestrom", MinChargeRate, MinChargeRateWarning, ChargeRateValue);
                BatteryOk = BatteryFactor.CheckMaximumWarningCondition("Ladestrom", MaxChargeRate, MaxChargeRateWarning, ChargeRateValue);
                if (BatteryOk)
                    BatteryFactor.NormalCondition("Ladestrom", ChargeRateValue);
            }
            else
            {
                BatteryOk = BatteryFactor.CheckMinimumWarningCondition("Charge Rate", MinChargeRate, MinChargeRateWarning, ChargeRateValue);
                BatteryOk = BatteryFactor.CheckMaximumWarningCondition("Charge Rate", MaxChargeRate, MaxChargeRateWarning, ChargeRateValue);
                if (BatteryOk)
                    BatteryFactor.NormalCondition("Charge Rate", ChargeRateValue);
            }
            return BatteryOk;
        }
    }
}
