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
        public static bool CheckTemperature(float TemperatureValue, string BatteryLanguage)
        {
            if (BatteryLanguage == "English")
            {
                BatteryOk = BatteryFactor.CheckMinimumWarningCondition("Temperature", MinTemperatureLimit, MinTemperatureWarning, TemperatureValue, BatteryLanguage);
                BatteryOk = BatteryFactor.CheckMaximumWarningCondition("Temperature", MaxTemperatureLimit, MaxTemperatureWarning, TemperatureValue, BatteryLanguage);
                if (BatteryOk)
                    BatteryFactor.NormalCondition("Temperature", TemperatureValue, BatteryLanguage);
            }
            else
            {
                BatteryOk = BatteryFactor.CheckMinimumWarningCondition("Temperatur", MinTemperatureLimit, MinTemperatureWarning, TemperatureValue, BatteryLanguage);
                BatteryOk = BatteryFactor.CheckMaximumWarningCondition("Temperatur", MaxTemperatureLimit, MaxTemperatureWarning, TemperatureValue, BatteryLanguage);
                if(BatteryOk)
                    BatteryFactor.NormalCondition("Temperatur", TemperatureValue, BatteryLanguage);
            }
            return BatteryOk;
        }
    }
}
