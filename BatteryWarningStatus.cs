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
        public static void CheckMinWarningBatteryCondition(string BatteryState, float BatteryValue, float MinBatteryValue, float MaxBatteryValue)
        {
            float MinBatteryWarning = MinBatteryValue + CheckwarningLimit(MaxBatteryValue);
            if (BatteryValue >= MinBatteryValue && BatteryValue <= MinBatteryWarning)
                BatteryConsolidate.MinWarning.Add(BatteryState);
        }
        public static void CheckMaxWarningBatteryCondition(string BatteryState, float BatteryValue, float MaxBatteryValue)
        {
            float MaxBatteryWarning = MaxBatteryValue - CheckwarningLimit(MaxBatteryValue);
            if (BatteryValue >= MaxBatteryValue && BatteryValue <= MaxBatteryWarning)
                BatteryConsolidate.MaxWarning.Add(BatteryState);
        }
    }
}
