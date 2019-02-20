using System.Threading.Tasks;
using MenuAPI;
using static CitizenFX.Core.Native.API;
using CitizenFX.Core;
using CitizenFX.Core.UI;

namespace AlsekRGB.Client
{
    public class NeonMenu : BaseScript
    {
        private Menu Neons;
        public static int PlayerVehicle;
        
        public static bool NeonsRainbowVar { get; private set; } = false;
        public static int AwaitDelayVar = 300;

        private void CreateMenu()
        {
            Neons = new Menu("Neons", "Neons are hot");
            
            MenuCheckboxItem NeonsRainbow = new MenuCheckboxItem("Neon Rainbow Circle", "Makes the neons rainbow and circle the vehicle you are in", NeonsRainbowVar)
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            Neons.AddMenuItem(NeonsRainbow);
            
            // AwaitDelay Dynamic List
            string AwaitDelayDyn(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = AwaitDelayVar - 1;
                    if (newvalue < 0)
                    {
                        newvalue = AwaitDelayVar = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Red~w~ is 0");
                        }
                    }
                    else
                    {
                        AwaitDelayVar = newvalue;
                    }
                }
                else
                {
                    var newvalue = AwaitDelayVar + 1;
                    if (newvalue > 255)
                    {
                        newvalue = AwaitDelayVar = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Red~w~ is 255");
                        }
                    }
                    else
                    {
                        AwaitDelayVar = newvalue;
                    }
                }
                return AwaitDelayVar.ToString();
            }
            MenuDynamicListItem AwaitDelayList = new MenuDynamicListItem("Rate", "300", AwaitDelayDyn, "Changes how quickly the neons change.");
            Neons.AddMenuItem(AwaitDelayList);
            // AwaitDelay Dynamic List
            
            
            /*
            ########################################################
                                Event handlers
            ########################################################
            */
            Neons.OnCheckboxChange += (_menu, _item, _index, _checked) =>
            {
                // Code in here gets executed whenever a checkbox is toggled.
                if (MainMenu.DebugMode == true)
                {
                    Debug.WriteLine($"OnCheckboxChange: [{_menu}, {_item}, {_index}, {_checked}]");
                }
                
                if (_item == NeonsRainbow)
                {
                    if (_checked)
                    {
                        PlayerVehicle = GetVehiclePedIsUsing(PlayerPedId());
                        NeonsRainbowVar = true;
                    }
                    else
                    {
                        NeonsRainbowVar = false;
                    }
                }
            };
        }
        
        public Menu GetMenu()
        {
            if (Neons == null)
            {
                CreateMenu();
            }
            return Neons;
        }

        public static async Task ProcessTask()
        {
            await Delay(0);
            if (NeonsRainbowVar == true)
            {
                SetVehicleNeonLightsColour(PlayerVehicle, 222, 222, 255);
                SetVehicleNeonLightEnabled(PlayerVehicle, 0, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 0, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, 3, 83, 255);
                SetVehicleNeonLightEnabled(PlayerVehicle, 2, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 2, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, 0, 250, 140);
                SetVehicleNeonLightEnabled(PlayerVehicle, 1, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 1, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, 255, 255, 0);
                SetVehicleNeonLightEnabled(PlayerVehicle, 3, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 3, false);
                //setting neons back to white
                SetVehicleNeonLightsColour(PlayerVehicle, 222, 222, 255);
            }
        }
    }
}