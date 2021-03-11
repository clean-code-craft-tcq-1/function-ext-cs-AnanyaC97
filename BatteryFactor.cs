using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryFactor
    {
        public static bool BatteryStatus = true;

        public static bool CheckMinimumWarningCondition(string BatteryState, float MinBatteryValue, float MinBatteryWarning, float BatteryValue)
        {
            if (BatteryValue < MinBatteryValue)
            {
                BatteryStatusDisplay.PrintMinimumLimit(BatteryState, MinBatteryValue, BatteryValue);
                return false;
            }
            else if (BatteryValue >= MinBatteryValue && BatteryValue <= MinBatteryWarning)
            {
                BatteryStatusDisplay.PrintMinimumWarning(BatteryState, MinBatteryWarning, BatteryValue);
                return false;
            }
            return true;
        }
        public static bool CheckMaximumWarningCondition(string BatteryState, float MaxBatteryValue, float MaxBatteryWarning, float BatteryValue)
        {
            if (BatteryValue >= MaxBatteryWarning && BatteryValue <= MaxBatteryValue)
            {
                BatteryStatusDisplay.PrintMaximumWarning(BatteryState, MaxBatteryWarning, BatteryValue);
                return false;
            }
            else if (BatteryValue > MaxBatteryValue)
            {
                BatteryStatusDisplay.PrintMinimumLimit(BatteryState, MaxBatteryValue, BatteryValue);
                return false;
            }
            return true;
        }
        public static void NormalCondition(string BatteryState, float BatteryValue)
        {
            BatteryStatusDisplay.PrintValid(BatteryState, BatteryValue);
        }
    }
}
