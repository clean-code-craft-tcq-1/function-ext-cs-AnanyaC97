using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryFactor
    {
        public static bool BatteryStatus = true;

        public static bool CheckMinimumWarningCondition(string BatteryState, float MinBatteryValue, float MinBatteryWarning, float BatteryValue, string BatteryLanguage)
        {
            if (BatteryValue < MinBatteryValue)
            {
                BatteryStatusDisplay.PrintMinimumLimit(BatteryState, MinBatteryValue, BatteryValue, BatteryLanguage);
                return false;
            }
            else if (BatteryValue >= MinBatteryValue && BatteryValue <= MinBatteryWarning)
            {
                BatteryStatusDisplay.PrintMinimumWarning(BatteryState, MinBatteryWarning, BatteryValue, BatteryLanguage);
                return false;
            }
            return true;
        }
        public static bool CheckMaximumWarningCondition(string BatteryState, float MaxBatteryValue, float MaxBatteryWarning, float BatteryValue, string BatteryLanguage)
        {
            if (BatteryValue >= MaxBatteryWarning && BatteryValue <= MaxBatteryValue)
            {
                BatteryStatusDisplay.PrintMaximumWarning(BatteryState, MaxBatteryWarning, BatteryValue, BatteryLanguage);
                return false;
            }
            else if (BatteryValue > MaxBatteryValue)
            {
                BatteryStatusDisplay.PrintMinimumLimit(BatteryState, MaxBatteryValue, BatteryValue, BatteryLanguage);
                return false;
            }
            return true;
        }
        public static void NormalCondition(string BatteryState, float BatteryValue, string BatteryLanguage)
        {
            BatteryStatusDisplay.PrintValid(BatteryState, BatteryValue, BatteryLanguage);
        }
    }
}
