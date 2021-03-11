using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryWarningStatus
    {
        public static float CheckwarningLimit(float BatteryValue)
        {
            return (float)(0.05 * BatteryValue);
        }
        public static void CheckMinWarningBatteryCondition(string BatteryState, float BatteryValue, float MinBatteryValue)
        {
            float MinBatteryWarning = MinBatteryValue + CheckwarningLimit(BatteryValue);
            if (BatteryValue >= MinBatteryValue && BatteryValue <= MinBatteryWarning)
                BatteryStatusDisplay.PrintMinimumWarning(BatteryState, MinBatteryWarning, BatteryValue);
        }
        public static void CheckMaxWarningBatteryCondition(string BatteryState, float BatteryValue, float MaxBatteryValue)
        {
            float MaxBatteryWarning = MaxBatteryValue - CheckwarningLimit(BatteryValue);
            if (BatteryValue >= MaxBatteryValue && BatteryValue <= MaxBatteryWarning)
                BatteryStatusDisplay.PrintMaximumWarning(BatteryState, MaxBatteryWarning, BatteryValue);
        }
    }
}
