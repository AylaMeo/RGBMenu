using System;
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
        public static NeonCustom NeonCustomMode { get; private set; }
        
        public static int PlayerVehicle;
        
        public static bool NeonsRainbowVar1 { get; private set; } = false;
        public static bool NeonsRainbowVar2 { get; private set; } = false;
        
        public static int AwaitDelayVar = 300;
        
        
        public static int RedNeon1 = 222;
        public static int GreenNeon1 = 222;
        public static int BlueNeon1 = 255;
        
        public static int RedNeon2 = 3;
        public static int GreenNeon2 = 83;
        public static int BlueNeon2 = 255;
         
        public static int RedNeon3 = 0;
        public static int GreenNeon3 = 250;
        public static int BlueNeon3 = 140;
       
        public static int RedNeon4 = 255;
        public static int GreenNeon4 = 255;
        public static int BlueNeon4 = 0;

        #region NeonCustomMode

        public static bool NeonsRainbowCustomVar = false;
        public static int FirstNeonVar = 0;
        public static int SecondNeonVar = 0;
        public static int ThirdNeonVar = 0;
        public static int FourthNeonVar = 0;

        #endregion
        
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
            
            //Adding the neon changer sub menu
            {
                NeonColor = new NeonChanger();
                Menu NeonChanger = NeonColor.GetMenu();
                MenuItem NeonButton = new MenuItem("Neon Color Picker", "Neon fine tuning !!THESE DO NOT TAKE EFFECT UNLESS YOU CYCLE ONE OF THE NEON MODES!!")
                {
                    Label = "→→→"
                };
                Neons.AddMenuItem(NeonButton);
                MenuController.BindMenuItem(Neons, NeonChanger, NeonButton);
            }
            
            //Adding the neon custom sub menu
            {
                NeonCustomMode = new NeonCustom();
                Menu NeonCustom = NeonCustomMode.GetMenu();
                MenuItem NeonCustomButton = new MenuItem("Custom Neon Mode", "A custom neon mode you can setup")
                {
                    Label = "→→→"
                };
                Neons.AddMenuItem(NeonCustomButton);
                MenuController.BindMenuItem(Neons, NeonCustom, NeonCustomButton);
            }

            
            /*
            ########################################################
                                Event handlers
            ########################################################
            */
            
            
            Neons.OnDynamicListItemSelect += (_menu, _dynamicListItem, _currentItem) =>
            {
                // Code in here would get executed whenever a dynamic list item is pressed.
                if (MainMenu.DebugMode == true)
                {
                    Debug.WriteLine($"OnDynamicListItemSelect: [{_menu}, {_dynamicListItem}, {_currentItem}]");
                }

                if (_dynamicListItem == AwaitDelayList)
                {
                    RateInput(1);
                }
            };
            
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
        
        #region PaintInput
        public static async void RateInput(int Type)
        {
            string result = await Functions.GetUserInput(windowTitle: "Enter a number between 0 and 1000", maxInputLength: 4);

            if (!string.IsNullOrEmpty(result))
            {
                int resultint = 0;
                Int32.TryParse(result, out resultint);

                #region Debug
                if (MainMenu.DebugMode == true)
                {
                    if (Type == 1)
                    {
                        Debug.Write($"Result:{resultint}/RedRGB:{AwaitDelayVar}");
                    }
                }
                #endregion
                
                if (resultint < 0)
                {
                    if (Type == 1)
                    {
                        Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Rate~w~ is 0");
                    }
                }
                if (resultint > 1000)
                {
                    if (Type == 1)
                    {
                        Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Rate~w~ is 1000");
                    }
                }
                else
                {
                    if (Type == 1)
                    {
                        AwaitDelayVar = resultint;
                    }

                    if (MainMenu.DebugMode == true)
                    {
                        if (Type == 1)
                        {
                            Debug.Write($"{AwaitDelayVar}");
                        }
                    }
                    else
                    {
                        return;
                    }  
                }
            }
            else
            {
                if (MainMenu.DebugMode == true)
                {
                    Screen.ShowNotification("Error: Field was empty (or other error)");
                }
            }    
        }
        #endregion
        
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
            if (NeonsRainbowCustomVar == true)
            {
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon1, NeonMenu.GreenNeon1, NeonMenu.BlueNeon1);
                if (FirstNeonVar != 4)
                {
                    SetVehicleNeonLightEnabled(PlayerVehicle, FirstNeonVar, true);
                    await Delay(AwaitDelayVar);
                    SetVehicleNeonLightEnabled(PlayerVehicle, FirstNeonVar, false);
                }

                if (SecondNeonVar != 4)
                {
                    await Delay(AwaitDelayVar);
                    SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon2, NeonMenu.GreenNeon2, NeonMenu.BlueNeon2);
                    SetVehicleNeonLightEnabled(PlayerVehicle, SecondNeonVar, true);
                    await Delay(AwaitDelayVar);
                    SetVehicleNeonLightEnabled(PlayerVehicle, SecondNeonVar, false);
                }

                if (ThirdNeonVar != 4)
                {
                    await Delay(AwaitDelayVar);
                    SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon3, NeonMenu.GreenNeon3, NeonMenu.BlueNeon3);
                    SetVehicleNeonLightEnabled(PlayerVehicle, ThirdNeonVar, true);
                    await Delay(AwaitDelayVar);
                    SetVehicleNeonLightEnabled(PlayerVehicle, ThirdNeonVar, false);
                }

                if (FourthNeonVar != 4)
                {
                    await Delay(AwaitDelayVar);
                    SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon4, NeonMenu.GreenNeon4, NeonMenu.BlueNeon4);
                    SetVehicleNeonLightEnabled(PlayerVehicle, FourthNeonVar, true);
                    await Delay(AwaitDelayVar);
                    SetVehicleNeonLightEnabled(PlayerVehicle, FourthNeonVar, false);
                }
            }
            
            if (NeonsRainbowVar1 == true)
            {
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon1, NeonMenu.GreenNeon1, NeonMenu.BlueNeon1);
                SetVehicleNeonLightEnabled(PlayerVehicle, 0, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 0, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon2, NeonMenu.GreenNeon2, NeonMenu.BlueNeon2);
                SetVehicleNeonLightEnabled(PlayerVehicle, 2, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 2, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon3, NeonMenu.GreenNeon3, NeonMenu.BlueNeon3);
                SetVehicleNeonLightEnabled(PlayerVehicle, 1, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 1, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon4, NeonMenu.GreenNeon4, NeonMenu.BlueNeon4);
                SetVehicleNeonLightEnabled(PlayerVehicle, 3, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 3, false);
            }
            if (NeonsRainbowVar2 == true)
            {

                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon1, NeonMenu.GreenNeon1, NeonMenu.BlueNeon1);
                SetVehicleNeonLightEnabled(PlayerVehicle, 0, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon2, NeonMenu.GreenNeon2, NeonMenu.BlueNeon2);
                SetVehicleNeonLightEnabled(PlayerVehicle, 2, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon3, NeonMenu.GreenNeon3, NeonMenu.BlueNeon3);
                SetVehicleNeonLightEnabled(PlayerVehicle, 1, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon4, NeonMenu.GreenNeon4, NeonMenu.BlueNeon4);
                SetVehicleNeonLightEnabled(PlayerVehicle, 3, true);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon1, NeonMenu.GreenNeon1, NeonMenu.BlueNeon1);
                SetVehicleNeonLightEnabled(PlayerVehicle, 0, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon2, NeonMenu.GreenNeon2, NeonMenu.BlueNeon2);
                SetVehicleNeonLightEnabled(PlayerVehicle, 2, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon3, NeonMenu.GreenNeon3, NeonMenu.BlueNeon3);
                SetVehicleNeonLightEnabled(PlayerVehicle, 1, false);
                await Delay(AwaitDelayVar);
                SetVehicleNeonLightEnabled(PlayerVehicle, 3, false);
                SetVehicleNeonLightsColour(PlayerVehicle, NeonMenu.RedNeon2, NeonMenu.GreenNeon2, NeonMenu.BlueNeon2);

            }
        }
    }
}