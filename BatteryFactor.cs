using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public class BatteryFactor
    {
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
            BatteryWarningStatus.CheckMinWarningBatteryCondition(BatteryState, BatteryValue, MinBatteryValue, MaxBatteryValue);
            BatteryWarningStatus.CheckMaxWarningBatteryCondition(BatteryState, BatteryValue, MaxBatteryValue);
            if (CheckMinContion(MinBatteryValue, BatteryValue))
            {
                BatteryConsolidate.MinimumLimit.Add(BatteryState);
                return false;
            }
            else if (CheckMaxCondition(MaxBatteryValue, BatteryValue))
            {
                BatteryConsolidate.MaximumLimit.Add(BatteryState);
                return false;
            }
            else
            {
                BatteryConsolidate.NormalLimit.Add(BatteryState);
                return true;
            }
        }
    }
}
