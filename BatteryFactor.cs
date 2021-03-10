using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryFactor
    {
        public static bool BatteryStatus = true;
        public static bool CheckBatteryCondition(string BatteryState, float MinBatteryValue, float MinBatteryWarning, float MaxBatteryValue, 
            float MaxBatteryWarning, float BatteryValue, string BatteryLanguage)
        {
            if (BatteryValue < MinBatteryValue)
            {
                BatteryStatusDisplay.PrintMinimumLimit(BatteryState, MinBatteryValue, BatteryValue, BatteryLanguage);
                BatteryStatus = false;
            }
            else if (BatteryValue >= MinBatteryValue && BatteryValue <= MinBatteryWarning)
            {
                BatteryStatusDisplay.PrintMinimumWarning(BatteryState, MinBatteryWarning, BatteryValue, BatteryLanguage);
                BatteryStatus = false;
            }
            else if (BatteryValue >= MaxBatteryWarning && BatteryValue <= MaxBatteryValue)
            {
                BatteryStatusDisplay.PrintMaximumWarning(BatteryState, MaxBatteryWarning, BatteryValue, BatteryLanguage);
                BatteryStatus = false;
            }
            else if (BatteryValue > MaxBatteryValue)
            {
                BatteryStatusDisplay.PrintMaximumLimit(BatteryState, MaxBatteryValue, BatteryValue, BatteryLanguage);
                BatteryStatus = false;
            }
            else
            {
                BatteryStatusDisplay.PrintValid(BatteryState, BatteryValue, BatteryLanguage);
                BatteryStatus = true;
            }
            return BatteryStatus;
        }
    }
}
