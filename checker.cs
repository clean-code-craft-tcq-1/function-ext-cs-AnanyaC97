using System;
using System.Diagnostics;

namespace BatteryManagement
{
    public class BatteryCheckerFactors
    {
        public static float minTemperatureLimit = 0;
        public static float maxTemperatureLimit = 45;
        public static float minStateOfCharge = 20;
        public static float maxStateOfCharge = 80;
        public static float minChargeRate = 0.5f;
        public static float maxChargeRate = 0.8f;
        public static string Language;
        public static bool batteryIsOk(float Temperature, float StateOfCharge, float ChargeRate, string Language)
        {
            bool optimumTemperatureLimit = BatteryTemperature.CheckTemperature(Temperature, Language);
            bool optimumStateOfCharge = BatteryStateOfCharge.CheckStateOfCharge(StateOfCharge, Language);
            bool optimumChargeRate = BatteryChargeRate.CheckChargeRate(ChargeRate, Language);

            if (optimumTemperatureLimit && optimumStateOfCharge && optimumChargeRate)
            {
                Console.WriteLine("Battery is ok!");
                return true;
            }
            else
            {
                Console.WriteLine("Battery is faulty!");
                return false;
            }
        }
        public static string LanguageInput()
        {
            Console.WriteLine("Please select language: \n1.English\n2.German \n");
            int LanguageChoice = int.Parse(Console.ReadLine());
            switch(LanguageChoice)
            {
                case 1:
                    Language = "English";
                    break;
                case 2:
                    Language = "German";
                    break;
                default:
                    Language = "Wrong Input";
                    Environment.Exit(0);
                    break;
            }
            return Language;
        }
        public static int Main()
        {
            Language = LanguageInput();

            BatteryStatusDisplay.ExpectTrue(batteryIsOk(25, 70, 0.7f, Language));
            BatteryStatusDisplay.ExpectFalse(batteryIsOk(50, 85, 0.0f, Language));
            BatteryStatusDisplay.ExpectFalse(batteryIsOk(-50, 10, 0.9f, Language));
            BatteryStatusDisplay.ExpectFalse(batteryIsOk(30, 100, 0.0f, Language));

            return 0;
        }
    }
}