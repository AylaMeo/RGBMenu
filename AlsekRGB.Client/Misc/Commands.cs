using System;
using System.Collections.Generic;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;

namespace AlsekRGB.Client
{
    public class Commands : BaseScript
    {
        public Commands()
        {
            API.RegisterCommand("RGBPaint", new Action<int, List<object>, string>((source, arguments, raw) =>
            {
                RGBPaint();
            }), false);
            
            API.RegisterCommand("NeonRate", new Action<int, List<object>, string>((source, arguments, raw) =>
            {
                NeonRate();
            }), false);
        }

        public static async void RGBPaint()
        {
            string result = await Functions.GetUserInput(windowTitle: "Enter color RGB separated by either a , or / (example 32,53,255)");

            if (!string.IsNullOrEmpty(result))
            {
                var numbers = result.Split(',', '/');
                var RedRGB = int.Parse(numbers[0]);
                var GreenRGB = int.Parse(numbers[1]);
                var BlueRGB = int.Parse(numbers[2]);

                if (MainMenu.DebugMode == true)
                {
                    Debug.Write($"R:{RedRGB}/G:{GreenRGB}/B:{BlueRGB}");
                }

                PaintMenu.RedRGB = RedRGB;
                PaintMenu.GreenRGB = GreenRGB;
                PaintMenu.BlueRGB = BlueRGB;
            }
            else
            {
                if (MainMenu.DebugMode == true)
                {
                    Screen.ShowNotification("Error: Field was empty (or other error)");
                }
            }
        }
        
        public static async void NeonRate()
        {
            string result = await Functions.GetUserInput(windowTitle: "Enter the rate of the neons)");

            if (!string.IsNullOrEmpty(result))
            {
                var NeonRate = int.Parse(result);

                if (MainMenu.DebugMode == true)
                {
                    Debug.Write($"Rate:{NeonRate}");
                }
                NeonMenu.AwaitDelayVar = NeonRate;
            }
            else
            {
                if (MainMenu.DebugMode == true)
                {
                    Screen.ShowNotification("Error: Field was empty (or other error)");
                }
            }
        }
    }
}