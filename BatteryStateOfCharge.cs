using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryStateOfCharge
    {
        public static float MinStateOfCharge = 20;
        public static float MaxStateOfCharge = 80;
        public static bool BatteryOk;
        public static bool CheckStateOfCharge(float StateOfCharge, string language)
        {
            if (language == "German")
            {
                BatteryOk = BatteryFactor.CheckBatteryStatus("Ladezustand", MinStateOfCharge, MaxStateOfCharge, StateOfCharge);
            }
            if (language == "English")
            {
                BatteryOk = BatteryFactor.CheckBatteryStatus("State Of Charge", MinStateOfCharge, MaxStateOfCharge, StateOfCharge);
            }
            return BatteryOk;
        }        
    }
}
