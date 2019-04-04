using System.Collections.Generic;
using MenuAPI;
using static CitizenFX.Core.Native.API;
using CitizenFX.Core;

namespace AlsekRGB.Client
{
    public class NeonCustom : BaseScript
    {
        private Menu NeonCustomMode;

        private void CreateMenu()
        {
           NeonCustomMode = new Menu($"{Dictionaries.LangNeon[8]}", $"{Dictionaries.LangNeon[9]}");
            
            #region CustomNeonMode
            
            MenuCheckboxItem NeonsRainbowCustom = new MenuCheckboxItem($"{Dictionaries.LangNeon[10]}", $"{Dictionaries.LangNeon[11]}", NeonMenu.NeonsRainbowCustomVar)
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            NeonCustomMode.AddMenuItem(NeonsRainbowCustom);
            
            //List for first neon
            var FirstNeonList = new List<string> { $"{Dictionaries.LangNeon[12]}", $"{Dictionaries.LangNeon[13]}", $"{Dictionaries.LangNeon[14]}", $"{Dictionaries.LangNeon[15]}", $"{Dictionaries.LangNeon[16]}"};
            MenuListItem FirstNeon = new MenuListItem($"{Dictionaries.LangNeon[17]}", FirstNeonList, 0, $"{Dictionaries.LangNeon[18]}");
            NeonCustomMode.AddMenuItem(FirstNeon);
            //List for first neon
            
            //List for Second neon
            var SecondNeonList = new List<string> { $"{Dictionaries.LangNeon[12]}", $"{Dictionaries.LangNeon[13]}", $"{Dictionaries.LangNeon[14]}", $"{Dictionaries.LangNeon[15]}", $"{Dictionaries.LangNeon[16]}"};
            MenuListItem SecondNeon = new MenuListItem($"{Dictionaries.LangNeon[19]}", SecondNeonList, 0, $"{Dictionaries.LangNeon[20]}");
            NeonCustomMode.AddMenuItem(SecondNeon);
            //List for Second neon
            
            //List for Third neon
            var ThirdNeonList = new List<string> { $"{Dictionaries.LangNeon[12]}", $"{Dictionaries.LangNeon[13]}", $"{Dictionaries.LangNeon[14]}", $"{Dictionaries.LangNeon[15]}", $"{Dictionaries.LangNeon[16]}"};
            MenuListItem ThirdNeon = new MenuListItem($"{Dictionaries.LangNeon[21]}", ThirdNeonList, 0, $"{Dictionaries.LangNeon[22]}");
            NeonCustomMode.AddMenuItem(ThirdNeon);
            //List for Third neon
            
            //List for Fourth neon
            var FourthNeonList = new List<string> { $"{Dictionaries.LangNeon[12]}", $"{Dictionaries.LangNeon[13]}", $"{Dictionaries.LangNeon[14]}", $"{Dictionaries.LangNeon[15]}", $"{Dictionaries.LangNeon[16]}"};
            MenuListItem FourthNeon = new MenuListItem($"{Dictionaries.LangNeon[23]}", FourthNeonList, 0, $"{Dictionaries.LangNeon[24]}");
            NeonCustomMode.AddMenuItem(FourthNeon);
            //List for Fourth neon
            
            #endregion

            /*
            ########################################################
                                Event handlers
            ########################################################
            */
         
            NeonCustomMode.OnListIndexChange += (_menu, _listItem, _oldIndex, _newIndex, _itemIndex) =>
            {
                // Code in here would get executed whenever a dynamic list item is pressed.
                if (MainMenu.DebugMode == true)
                {
                    Debug.WriteLine($"OnListIndexChange: [{_menu}, {_listItem}, {_oldIndex}, {_newIndex}, {_itemIndex}]");
                }
                var None = "None";
                var Left = "Left";
                var Right = "Right";
                var Back = "Back";
                var Front = "Front";
                
                if (_listItem == FirstNeon)
                {
                    var value = FirstNeonList[_newIndex];
                    //Screen.ShowNotification($"{value}");
                    if (value == None)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.FirstNeonVar, false);
                        NeonMenu.FirstNeonVar = 4;
                    }
                    if (value == Left)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.FirstNeonVar, false);
                        NeonMenu.FirstNeonVar = 0;
                    }
                    if (value == Right)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.FirstNeonVar, false);
                        NeonMenu.FirstNeonVar = 1;
                    }
                    if (value == Front)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.FirstNeonVar, false);
                        NeonMenu.FirstNeonVar = 2;
                    }
                    if (value == Back)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.FirstNeonVar, false);
                        NeonMenu.FirstNeonVar = 3;
                    }
                }
                
                if (_listItem == SecondNeon)
                {
                    var value = SecondNeonList[_newIndex];
                    //Screen.ShowNotification($"{value}");
                    if (value == None)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.SecondNeonVar, false);
                        NeonMenu.SecondNeonVar = 4;
                    }
                    if (value == Left)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.SecondNeonVar, false);
                        NeonMenu.SecondNeonVar = 0;
                    }
                    if (value == Right)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.SecondNeonVar, false);
                        NeonMenu.SecondNeonVar = 1;
                    }
                    if (value == Front)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.SecondNeonVar, false);
                        NeonMenu.SecondNeonVar = 2;
                    }
                    if (value == Back)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.SecondNeonVar, false);
                        NeonMenu.SecondNeonVar = 3;
                    }
                    else
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.SecondNeonVar, false);
                    }
                }
                
                if (_listItem == ThirdNeon)
                {
                    var value = FirstNeonList[_newIndex];
                    //Screen.ShowNotification($"{value}");
                    if (value == None)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.ThirdNeonVar, false);
                        NeonMenu.ThirdNeonVar = 4;
                    }
                    if (value == Left)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.ThirdNeonVar, false);
                        NeonMenu.ThirdNeonVar = 0;
                    }
                    if (value == Right)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.ThirdNeonVar, false);
                        NeonMenu.ThirdNeonVar = 1;
                    }
                    if (value == Front)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.ThirdNeonVar, false);
                        NeonMenu.ThirdNeonVar = 2;
                    }
                    if (value == Back)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.ThirdNeonVar, false);
                        NeonMenu.ThirdNeonVar = 3;
                    }
                    else
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.ThirdNeonVar, false);
                    }
                }
                
                if (_listItem == FourthNeon)
                {
                    var value = FourthNeonList[_newIndex];
                    //Screen.ShowNotification($"{value}");
                    if (value == None)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.FourthNeonVar, false);
                        NeonMenu.FourthNeonVar = 4;
                    }
                    if (value == Left)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.FourthNeonVar, false);
                        NeonMenu.FourthNeonVar = 0;
                    }
                    if (value == Right)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.FourthNeonVar, false);
                        NeonMenu.FourthNeonVar = 1;
                    }
                    if (value == Front)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.FourthNeonVar, false);
                        NeonMenu.FourthNeonVar = 2;
                    }
                    if (value == Back)
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.FourthNeonVar, false);
                        NeonMenu.FourthNeonVar = 3;
                    }
                    else
                    {
                        SetVehicleNeonLightEnabled(NeonMenu.PlayerVehicle, NeonMenu.FourthNeonVar, false);
                    }
                }
            };
            
            NeonCustomMode.OnCheckboxChange += (_menu, _item, _index, _checked) =>
            {
                // Code in here gets executed whenever a checkbox is toggled.
                if (MainMenu.DebugMode == true)
                {
                    Debug.WriteLine($"OnCheckboxChange: [{_menu}, {_item}, {_index}, {_checked}]");
                }
                
                if (_item == NeonsRainbowCustom)
                {
                    if (_checked)
                    {
                        NeonMenu.PlayerVehicle = GetVehiclePedIsUsing(PlayerPedId());
                        NeonMenu.NeonsRainbowCustomVar = true;
                    }
                    else
                    {
                        NeonMenu.NeonsRainbowCustomVar = false;
                    }
                }
            };
        }
        
        public Menu GetMenu()
        {
            if (NeonCustomMode == null)
            {
                CreateMenu();
            }
            return NeonCustomMode;
        }
    }
}