using CitizenFX.Core;
using System;
using System.Threading.Tasks;
using CitizenFX.Core.UI;
using MenuAPI;
using static CitizenFX.Core.Native.API;

namespace AlsekRGB.Client
{
    public class ClientScript : BaseScript
    {
        public static int RedR = 0;
        
        public ClientScript()
        {
            EventHandlers.Add("Alsek:Red", new Action(Red));  
            EventHandlers.Add("Alsek:RedCon", new Action(TickColor));
            // constructor code
        }
        
        
        /// <summary>
        /// Red Test Code
        /// </summary>
        public static async Task RedCon()
        {
            await Delay(0);
            if (Game.IsControlJustPressed(0, Control.PhoneLeft))
            {
                RedR--;
                Screen.ShowNotification($"{RedR}");
                Debug.Write($"{RedR}");
                return;
            }
            if (Game.IsControlJustPressed(0, Control.PhoneRight))
            {
                RedR++;
                Screen.ShowNotification($"{RedR}");
                Debug.Write($"{RedR}");
                return;
            }
            
            else
            {
                return;
            }
        }
        
        public static async Task RedManger()
        {
            await Delay(0);
            if (RedR == -1)
            {
                RedR = 255;
            }

            if (RedR == 256)
            {
                RedR = 0;
            }
        }
                
        /// <summary>
        /// Red Test Code
        /// </summary>
        private void Red()
        {
            /*
            // Debug.Write("Showing Message on client");
            //Screen.ShowNotification($"~b~Debug~s~: test {Game.Player.Name}!");
            var PlayerVehicle = GetPlayersLastVehicle();
            //int Red = 0;
            SetVehicleCustomPrimaryColour(PlayerVehicle, RedR, 0, 0); */
        }
        
        public void TickColor()
        {
            Tick += RedCon;
            Tick += RedManger;
        } 
    }
}