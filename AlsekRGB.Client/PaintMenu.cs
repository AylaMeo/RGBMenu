using System;
using CitizenFX.Core;
using CitizenFX.Core.UI;
using static CitizenFX.Core.Native.API;
using MenuAPI;

namespace AlsekRGB.Client
{
    public class PaintMenu
    {
        //menu variables
        private Menu Paint;
        //menu variables
        
        //color variables
        public static int RedRGB = 0;
        public static int BlueRGB = 0;
        public static int GreenRGB = 0;
        public static bool ApplyColorPrimary { get; private set; } = false;
        public static bool ApplyColorSecondary { get; private set; } = false;
        //color variables

        
        private void CreateMenu()
        {
            Paint = new Menu($"{Dictionaries.LangMain[1]}", $"{Dictionaries.LangMain[2]}");
            
            /*
            ########################################################
                                 Paint
            */       
            //Box for applying primary paint
            MenuCheckboxItem paintPrimary = new MenuCheckboxItem($"{Dictionaries.LangPaint[0]}", $"{Dictionaries.LangPaint[1]}", ApplyColorPrimary)
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            Paint.AddMenuItem(paintPrimary);
            //Box for applying primary paint
            //Box for applying secondary paint
            MenuCheckboxItem paintSecondary = new MenuCheckboxItem($"{Dictionaries.LangPaint[2]}", $"{Dictionaries.LangPaint[1]}", ApplyColorSecondary)
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            Paint.AddMenuItem(paintSecondary);
            //Box for applying secondary paint
               
            // Red Dynamic List
            string RedDyn(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = RedRGB - 1;
                    if (newvalue < 0)
                    {
                        newvalue = RedRGB = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Red~w~ is 0");
                        }
                    }
                    else
                    {
                        RedRGB = newvalue;
                    }
                }
                else
                {
                    var newvalue = RedRGB + 1;
                    if (newvalue > 255)
                    {
                        newvalue = RedRGB = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Red~w~ is 255");
                        }
                    }
                    else
                    {
                        RedRGB = newvalue;
                    }
                }
                return RedRGB.ToString();
            }
            MenuDynamicListItem RedDynList = new MenuDynamicListItem($"{Dictionaries.LangPaint[3]}", "0", RedDyn, $"{Dictionaries.LangPaint[4]}");
            Paint.AddMenuItem(RedDynList);
            // Red Dynamic List
            
            // Green Dynamic List
            string GreenDyn(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = GreenRGB - 1;
                    if (newvalue < 0)
                    {
                        newvalue = GreenRGB = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        GreenRGB = newvalue;
                    }
                }
                else
                {
                    var newvalue = GreenRGB + 1;
                    if (newvalue > 255)
                    {
                        newvalue = GreenRGB = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        GreenRGB = newvalue;
                    }
                }
                return GreenRGB.ToString();
            }
            MenuDynamicListItem GreenDynList = new MenuDynamicListItem($"{Dictionaries.LangPaint[5]}", "0", GreenDyn, $"{Dictionaries.LangPaint[6]}");
            Paint.AddMenuItem(GreenDynList);
            // Green Dynamic List
            
            // Blue Dynamic List
            string BlueDyn(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = BlueRGB - 1;
                    if (newvalue < 0)
                    {
                        newvalue = BlueRGB = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        BlueRGB = newvalue;
                    }
                }
                else
                {
                    var newvalue = BlueRGB + 1;
                    if (newvalue > 255)
                    {
                        newvalue = BlueRGB = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        BlueRGB = newvalue;
                    }
                }
                return BlueRGB.ToString();
            }
            MenuDynamicListItem BlueDynList = new MenuDynamicListItem($"{Dictionaries.LangPaint[7]}", "0", BlueDyn, $"{Dictionaries.LangPaint[8]}");
            Paint.AddMenuItem(BlueDynList);
            // Blue Dynamic List
            /*
                     Paint
            ########################################################
            */  
            
            /*
            ########################################################
                                Event handlers
            ########################################################
            */
            Paint.OnDynamicListItemSelect += (_menu, _dynamicListItem, _currentItem) =>
            {
                // Code in here would get executed whenever a dynamic list item is pressed.
                if (MainMenu.DebugMode == true)
                {
                    Debug.WriteLine($"OnDynamicListItemSelect: [{_menu}, {_dynamicListItem}, {_currentItem}]");
                }

                if (_dynamicListItem == RedDynList)
                {
                    PaintInput(1);
                }
                
                if (_dynamicListItem == GreenDynList)
                {
                    PaintInput(2);
                }
                
                if (_dynamicListItem == BlueDynList)
                {
                    PaintInput(3);
                }
            };
            
            
            Paint.OnDynamicListItemCurrentItemChange += ( _menu, _dynamicListItem, _oldCurrentItem, __newCurrentItem) => 
            {
                // Code in here would get executed whenever the value of the current item of a dynamic list item changes.
                if (MainMenu.DebugMode == true)
                {
                    Debug.WriteLine($"OnMenuDynamicListItemCurrentItemChange: [{_menu}, {_dynamicListItem}, {_oldCurrentItem}, {__newCurrentItem}]");
                }

                if (_dynamicListItem == RedDynList)
                {
                    if (ApplyColorPrimary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomPrimaryColour(PlayerVehicle, RedRGB, GreenRGB, BlueRGB);
                    }
                    if (ApplyColorSecondary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomSecondaryColour(PlayerVehicle, RedRGB, GreenRGB, BlueRGB);
                    }
                    if (MainMenu.DebugMode == true)
                    {
                        Debug.Write($"{RedRGB}");
                    }
                    else
                    {
                        return;
                    }   
                }

                if (_dynamicListItem == GreenDynList)
                {
                    if (ApplyColorPrimary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomPrimaryColour(PlayerVehicle, RedRGB, GreenRGB, BlueRGB);
                    }
                    if (ApplyColorSecondary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomSecondaryColour(PlayerVehicle, RedRGB, GreenRGB, BlueRGB);
                    }
                    if (MainMenu.DebugMode == true)
                    {
                        Debug.Write($"{GreenRGB}");
                    }
                    else
                    {
                        return;
                    }
                }

                if (_dynamicListItem == BlueDynList)
                {
                    if (ApplyColorPrimary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomPrimaryColour(PlayerVehicle, RedRGB, GreenRGB, BlueRGB);
                    }
                    if (ApplyColorSecondary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomSecondaryColour(PlayerVehicle, RedRGB, GreenRGB, BlueRGB);
                    }
                    if (MainMenu.DebugMode == true)
                    {
                        Debug.Write($"{BlueRGB}");
                    }
                    else
                    {
                        return;
                    }
                }
            };            
            
            Paint.OnCheckboxChange += (_menu, _item, _index, _checked) =>
            {
                // Code in here gets executed whenever a checkbox is toggled.
                if (MainMenu.DebugMode == true)
                {
                    Debug.WriteLine($"OnCheckboxChange: [{_menu}, {_item}, {_index}, {_checked}]");
                }
                if (_item == paintPrimary)
                {
                    if (_checked)
                    {
                        ApplyColorPrimary = true;
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomPrimaryColour(PlayerVehicle, RedRGB, GreenRGB, BlueRGB);
                    }
                    else
                    {
                        ApplyColorPrimary = false;
                    }
                }
                
                if (_item == paintSecondary)
                {
                    if (_checked)
                    {
                        ApplyColorSecondary = true;
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomSecondaryColour(PlayerVehicle, RedRGB, GreenRGB, BlueRGB);
                    }
                    else
                    {
                        ApplyColorSecondary = false;
                    }
                }
            };
        }

        #region PaintInput
        public static async void PaintInput(int Type)
        {
            string result = await Functions.GetUserInput(windowTitle: "Enter a number between 0 and 255", maxInputLength: 3);

            if (!string.IsNullOrEmpty(result))
            {
                int resultint = 0;
                Int32.TryParse(result, out resultint);

                #region Debug
                if (MainMenu.DebugMode == true)
                {
                    if (Type == 1)
                    {
                        Debug.Write($"Result:{resultint}/RedRGB:{PaintMenu.RedRGB}");
                    }
                    if (Type == 2)
                    {
                        Debug.Write($"Result:{resultint}/Green:{PaintMenu.GreenRGB}");
                    }
                    if (Type == 3)
                    {
                        Debug.Write($"Result:{resultint}/BlueRGB:{PaintMenu.BlueRGB}");
                    }
                }
                #endregion
                
                if (resultint < 0)
                {
                    if (Type == 1)
                    {
                        Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Red~w~ is 0");
                    }
                    if (Type == 2)
                    {
                        Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                    }
                    if (Type == 3)
                    {
                        Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Blue~w~ is 0");
                    }
                }
                if (resultint > 255)
                {
                    if (Type == 1)
                    {
                        Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Red~w~ is 255");
                    }
                    if (Type == 2)
                    {
                        Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                    }
                    if (Type == 3)
                    {
                        Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Blue~w~ is 255");
                    }
                }
                else
                {
                    if (Type == 1)
                    {
                        PaintMenu.RedRGB = resultint;
                    }
                    if (Type == 2)
                    {
                        PaintMenu.GreenRGB = resultint;
                    }
                    if (Type == 3)
                    {
                        PaintMenu.BlueRGB = resultint;
                    }

                    if (ApplyColorPrimary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomPrimaryColour(PlayerVehicle, RedRGB, GreenRGB, BlueRGB);
                    }
                    if (ApplyColorSecondary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomSecondaryColour(PlayerVehicle, RedRGB, GreenRGB, BlueRGB);
                    }
                    if (MainMenu.DebugMode == true)
                    {
                        if (Type == 1)
                        {
                            Debug.Write($"{RedRGB}");
                        }
                        if (Type == 2)
                        {
                            Debug.Write($"{GreenRGB}");
                        }
                        if (Type == 3)
                        {
                            Debug.Write($"{BlueRGB}");
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
            if (Paint == null)
            {
                CreateMenu();
            }
            return Paint;
        }
    }
}