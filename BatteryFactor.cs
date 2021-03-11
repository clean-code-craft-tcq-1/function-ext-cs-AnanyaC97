using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryFactor
    {
        public static bool BatteryStatus = true;
        public static bool CheckMaxCondition(float MaxBatteryValue, float BatteryValue)
        {
            return BatteryValue > MaxBatteryValue ? true : false;
        }
        public static bool CheckMinContion(float MinBatteryValue, float BatteryValue)
        {
            return BatteryValue < MinBatteryValue ? true : false;
        }
        public static bool CheckBatteryStatus(string BatteryState, float MinBatteryValue, float MaxBatteryValue, float BatteryValue)
        {
            BatteryWarningStatus.CheckMinWarningBatteryCondition(BatteryState, MinBatteryValue, BatteryValue);
            BatteryWarningStatus.CheckMaxWarningBatteryCondition(BatteryState, MaxBatteryValue, BatteryValue);
            if (CheckMinContion(MinBatteryValue, BatteryValue))
            {
                BatteryStatusDisplay.PrintMinimumLimit(BatteryState, MinBatteryValue, BatteryValue);
                return false;
            }
            else if (CheckMaxCondition(MaxBatteryValue, BatteryValue))
            {
                BatteryStatusDisplay.PrintMaximumLimit(BatteryState, MaxBatteryValue, BatteryValue);
                return false;
            }
            else
            {
                BatteryStatusDisplay.PrintValid(BatteryState, BatteryValue);
                return true;
            }
        }
    }
}
