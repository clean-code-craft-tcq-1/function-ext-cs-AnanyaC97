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
                BatteryOk = BatteryFactor.CheckBatteryCondition("State Of Charge", MinStateOfCharge, MinStateOfChargeWarning,
                MaxStateOfCharge, MaxStateOfChargeWarning, StateOfCharge, BatteryLanguage);
            else
                BatteryOk = BatteryFactor.CheckBatteryCondition("Ladezustand", MinStateOfCharge, MinStateOfChargeWarning,
                MaxStateOfCharge, MaxStateOfChargeWarning, StateOfCharge, BatteryLanguage);
            return BatteryOk;
        }
    }
}
