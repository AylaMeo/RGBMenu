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
        
        public static NeonChanger NeonColor { get; private set; }
        
        public static int PlayerVehicle;
        
        public static bool NeonsRainbowVar1 { get; private set; } = false;
        public static bool NeonsRainbowVar2 { get; private set; } = false;
        public static int AwaitDelayVar = 300;

        private void CreateMenu()
        {
            Neons = new Menu("Neons", "Neons are hot");
            
            MenuCheckboxItem NeonsRainbow = new MenuCheckboxItem("Neon Rainbow Circle", "Makes the neons rainbow and circle the vehicle you are in", NeonsRainbowVar1)
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            Neons.AddMenuItem(NeonsRainbow);
            
            MenuCheckboxItem NeonsRainbow2 = new MenuCheckboxItem("Neon Rainbow Circle 2", "A slightly different circle option", NeonsRainbowVar2)
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            Neons.AddMenuItem(NeonsRainbow2);
            
            // AwaitDelay Dynamic List
            string AwaitDelayDyn(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = AwaitDelayVar - 1;
                    if (newvalue < 0)
                    {
                        newvalue = AwaitDelayVar = 300;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Rate~w~ is 0");
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
                    AwaitDelayVar = newvalue;
                }
                return AwaitDelayVar.ToString();
            }
            MenuDynamicListItem AwaitDelayList = new MenuDynamicListItem("Rate", "300", AwaitDelayDyn, "Changes how quickly the neons change.");
            Neons.AddMenuItem(AwaitDelayList);
            // AwaitDelay Dynamic List
            
            //Adding the paint sub menu
            {
                NeonColor = new NeonChanger();
                Menu NeonChanger = NeonColor.GetMenu();
                MenuItem PaintButton = new MenuItem("Neon Color Picker", "Neon fine tuning")
                {
                    Label = "→→→"
                };
                Neons.AddMenuItem(PaintButton);
                MenuController.BindMenuItem(Neons, NeonChanger, PaintButton);
            }
            
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
                        NeonsRainbowVar1 = true;
                    }
                    else
                    {
                        NeonsRainbowVar1 = false;
                    }
                }
                
                if (_item == NeonsRainbow2)
                {
                    if (_checked)
                    {
                        PlayerVehicle = GetVehiclePedIsUsing(PlayerPedId());
                        NeonsRainbowVar2 = true;
                    }
                    else
                    {
                        NeonsRainbowVar2 = false;
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
            if (NeonsRainbowVar1 == true)
            {
                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon1, NeonColor.GreenNeon1, NeonColor.BlueNeon1);
                SetVehicleNeonLightEnabled(PlayerVehicle, 0, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 0, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon2, NeonColor.GreenNeon2, NeonColor.BlueNeon2);
                SetVehicleNeonLightEnabled(PlayerVehicle, 2, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 2, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon3, NeonColor.GreenNeon3, NeonColor.BlueNeon3);
                SetVehicleNeonLightEnabled(PlayerVehicle, 1, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 1, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon4, NeonColor.GreenNeon4, NeonColor.BlueNeon4);
                SetVehicleNeonLightEnabled(PlayerVehicle, 3, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 3, false);
            }
            if (NeonsRainbowVar2 == true)
            {

                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon1, NeonColor.GreenNeon1, NeonColor.BlueNeon1);
                SetVehicleNeonLightEnabled(PlayerVehicle, 0, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon2, NeonColor.GreenNeon2, NeonColor.BlueNeon2);
                SetVehicleNeonLightEnabled(PlayerVehicle, 2, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon3, NeonColor.GreenNeon3, NeonColor.BlueNeon3);
                SetVehicleNeonLightEnabled(PlayerVehicle, 1, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon4, NeonColor.GreenNeon4, NeonColor.BlueNeon4);
                SetVehicleNeonLightEnabled(PlayerVehicle, 3, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon1, NeonColor.GreenNeon1, NeonColor.BlueNeon1);
                SetVehicleNeonLightEnabled(PlayerVehicle, 0, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon2, NeonColor.GreenNeon2, NeonColor.BlueNeon2);
                SetVehicleNeonLightEnabled(PlayerVehicle, 2, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon3, NeonColor.GreenNeon3, NeonColor.BlueNeon3);
                SetVehicleNeonLightEnabled(PlayerVehicle, 1, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 3, false);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonColor.RedNeon2, NeonColor.GreenNeon2, NeonColor.BlueNeon2);

            }
        }
    }
}