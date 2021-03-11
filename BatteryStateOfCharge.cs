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
        public static bool CheckStateOfCharge(float StateOfCharge)
        {
            if (BatteryCheckerFactors.GermanLanguage)
            {
                BatteryOk = BatteryFactor.CheckMinimumWarningCondition("Ladezustand", MinStateOfCharge, MinStateOfChargeWarning, StateOfCharge);
                BatteryOk = BatteryFactor.CheckMaximumWarningCondition("Ladezustand", MaxStateOfCharge, MaxStateOfChargeWarning, StateOfCharge);
                if (BatteryOk)
                    BatteryFactor.NormalCondition("Ladezustand", StateOfCharge);
            }
            else
            {
                BatteryOk = BatteryFactor.CheckMinimumWarningCondition("State Of Charge", MinStateOfCharge, MinStateOfChargeWarning, StateOfCharge);
                BatteryOk = BatteryFactor.CheckMaximumWarningCondition("State Of Charge", MaxStateOfCharge, MaxStateOfChargeWarning, StateOfCharge);
                if (BatteryOk)
                    BatteryFactor.NormalCondition("State Of Charge", StateOfCharge);
            }
            return BatteryOk;
        }        
    }
}
