using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryStateOfCharge
    {
        public static float MinStateOfCharge = 20;
        public static float MaxStateOfCharge = 80;
        public static float MinStateOfChargeWarning = (float)(MinStateOfCharge + (0.05 * MaxStateOfCharge));
        public static float MaxStateOfChargeWarning = (float)(MaxStateOfCharge - (0.05 * MaxStateOfCharge));
        public static bool BatteryOk;
        public static bool CheckStateOfCharge(float StateOfCharge, string BatteryLanguage)
        {
            if (BatteryLanguage == "English")
            {
                BatteryOk = BatteryFactor.CheckMinimumWarningCondition("State Of Charge", MinStateOfCharge, MinStateOfChargeWarning, StateOfCharge, BatteryLanguage);
                BatteryOk = BatteryFactor.CheckMaximumWarningCondition("State Of Charge", MaxStateOfCharge, MaxStateOfChargeWarning, StateOfCharge, BatteryLanguage);
                if (BatteryOk)
                    BatteryFactor.NormalCondition("State Of Charge", StateOfCharge, BatteryLanguage);
            }
            else
            {
                BatteryOk = BatteryFactor.CheckMinimumWarningCondition("Ladezustand", MinStateOfCharge, MinStateOfChargeWarning, StateOfCharge, BatteryLanguage);
                BatteryOk = BatteryFactor.CheckMaximumWarningCondition("Ladezustand", MaxStateOfCharge, MaxStateOfChargeWarning, StateOfCharge, BatteryLanguage);
                if (BatteryOk)
                    BatteryFactor.NormalCondition("Ladezustand", StateOfCharge, BatteryLanguage);
            }
            return BatteryOk;
        }        
    }
}
