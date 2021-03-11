using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryTemperature
    {
        public static float MinTemperatureLimit = 0;
        public static float MaxTemperatureLimit = 45;
        public static float MinTemperatureWarning = (float)(MinTemperatureLimit + (0.05 * MaxTemperatureLimit));
        public static float MaxTemperatureWarning = (float)(MaxTemperatureLimit - (0.05 * MaxTemperatureLimit));
        public static bool BatteryOk;
        public static bool CheckTemperature(float TemperatureValue)
        {
            if (BatteryCheckerFactors.GermanLanguage)
            {
                BatteryOk = BatteryFactor.CheckMinimumWarningCondition("Temperatur", MinTemperatureLimit, MinTemperatureWarning, TemperatureValue);
                BatteryOk = BatteryFactor.CheckMaximumWarningCondition("Temperatur", MaxTemperatureLimit, MaxTemperatureWarning, TemperatureValue);
                if (BatteryOk)
                    BatteryFactor.NormalCondition("Temperatur", TemperatureValue);
            }
            else
            {
                BatteryOk = BatteryFactor.CheckMinimumWarningCondition("Temperature", MinTemperatureLimit, MinTemperatureWarning, TemperatureValue);
                BatteryOk = BatteryFactor.CheckMaximumWarningCondition("Temperature", MaxTemperatureLimit, MaxTemperatureWarning, TemperatureValue);
                if (BatteryOk)
                    BatteryFactor.NormalCondition("Temperature", TemperatureValue);
            }
            return BatteryOk;
        }
    }
}
