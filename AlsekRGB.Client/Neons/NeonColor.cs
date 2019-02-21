using System;
using CitizenFX.Core;
using CitizenFX.Core.UI;
using MenuAPI;

namespace AlsekRGB.Client
{
    public class NeonChanger
    {
        private Menu NeonColor;

        private void CreateMenu()
        {
            NeonColor = new Menu("Neon Colors", "Neon tuning");

            #region Neon1
            // Red Dynamic List
            string RedDyn1(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.RedNeon1 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.RedNeon1 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Red~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.RedNeon1 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.RedNeon1 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.RedNeon1 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Red~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.RedNeon1 = newvalue;
                    }
                }
                return NeonMenu.RedNeon1.ToString();
            }
            MenuDynamicListItem RedDynList1 = new MenuDynamicListItem("Red Left", "222", RedDyn1, "Set the red in RGB.");
            NeonColor.AddMenuItem(RedDynList1);
            // Red Dynamic List
            
            // Green Dynamic List
            string GreenDyn1(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.GreenNeon1 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.GreenNeon1 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.GreenNeon1 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.GreenNeon1 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.GreenNeon1 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.GreenNeon1 = newvalue;
                    }
                }
                return NeonMenu.GreenNeon1.ToString();
            }
            MenuDynamicListItem GreenDynList1 = new MenuDynamicListItem("Green Left", "222", GreenDyn1, "Set the Green in RGB.");
            NeonColor.AddMenuItem(GreenDynList1);
            // Green Dynamic List
            
            // Blue Dynamic List
            string BlueDyn1(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.BlueNeon1 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.BlueNeon1 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.BlueNeon1 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.BlueNeon1 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.BlueNeon1 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.BlueNeon1 = newvalue;
                    }
                }
                return NeonMenu.BlueNeon1.ToString();
            }
            MenuDynamicListItem BlueDynList1 = new MenuDynamicListItem("Blue Left", "255", BlueDyn1, "Set the Blue in RGB.");
            NeonColor.AddMenuItem(BlueDynList1);
            // Blue Dynamic List
            #endregion
            
            NeonColor.AddMenuItem(new MenuItem("====", "This is a separator!"));
            
            #region Neon2
            // Red Dynamic List
            string RedDyn2(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.RedNeon2 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.RedNeon2 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Red~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.RedNeon2 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.RedNeon2 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.RedNeon2 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Red~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.RedNeon2 = newvalue;
                    }
                }
                return NeonMenu.RedNeon2.ToString();
            }
            MenuDynamicListItem RedDynList2 = new MenuDynamicListItem("Red Front", "3", RedDyn2, "Set the red in RGB.");
            NeonColor.AddMenuItem(RedDynList2);
            // Red Dynamic List
            
            // Green Dynamic List
            string GreenDyn2(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.GreenNeon2 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.GreenNeon2 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.GreenNeon2 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.GreenNeon2 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.GreenNeon2 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.GreenNeon2 = newvalue;
                    }
                }
                return NeonMenu.GreenNeon2.ToString();
            }
            MenuDynamicListItem GreenDynList2 = new MenuDynamicListItem("Green Front", "83", GreenDyn2, "Set the Green in RGB.");
            NeonColor.AddMenuItem(GreenDynList2);
            // Green Dynamic List
            
            // Blue Dynamic List
            string BlueDyn2(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.BlueNeon2 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.BlueNeon2 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.BlueNeon2 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.BlueNeon2 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.BlueNeon2 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.BlueNeon2 = newvalue;
                    }
                }
                return NeonMenu.BlueNeon2.ToString();
            }
            MenuDynamicListItem BlueDynList2 = new MenuDynamicListItem("Blue Front", "255", BlueDyn2, "Set the Blue in RGB.");
            NeonColor.AddMenuItem(BlueDynList2);
            // Blue Dynamic List
            #endregion
            
            NeonColor.AddMenuItem(new MenuItem("====", "This is a separator!"));
            
            #region Neon3
            // Red Dynamic List
            string RedDyn3(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.RedNeon3 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.RedNeon3 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Red~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.RedNeon3 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.RedNeon3 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.RedNeon3 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Red~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.RedNeon3 = newvalue;
                    }
                }
                return NeonMenu.RedNeon3.ToString();
            }
            MenuDynamicListItem RedDynList3 = new MenuDynamicListItem("Red Right", "0", RedDyn3, "Set the red in RGB.");
            NeonColor.AddMenuItem(RedDynList3);
            // Red Dynamic List
            
            // Green Dynamic List
            string GreenDyn3(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.GreenNeon3 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.GreenNeon3 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.GreenNeon3 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.GreenNeon3 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.GreenNeon3 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.GreenNeon3 = newvalue;
                    }
                }
                return NeonMenu.GreenNeon3.ToString();
            }
            MenuDynamicListItem GreenDynList3 = new MenuDynamicListItem("Green Right", "250", GreenDyn3, "Set the Green in RGB.");
            NeonColor.AddMenuItem(GreenDynList3);
            // Green Dynamic List
            
            // Blue Dynamic List
            string BlueDyn3(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.BlueNeon3 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.BlueNeon3 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.BlueNeon3 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.BlueNeon3 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.BlueNeon3 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.BlueNeon3 = newvalue;
                    }
                }
                return NeonMenu.BlueNeon3.ToString();
            }
            MenuDynamicListItem BlueDynList3 = new MenuDynamicListItem("Blue Right", "140", BlueDyn3, "Set the Blue in RGB.");
            NeonColor.AddMenuItem(BlueDynList3);
            // Blue Dynamic List
            #endregion
            
            NeonColor.AddMenuItem(new MenuItem("====", "This is a separator!"));
            
            #region Neon4
            // Red Dynamic List
            string RedDyn4(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.RedNeon4 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.RedNeon4 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Red~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.RedNeon4 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.RedNeon4 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.RedNeon4 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Red~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.RedNeon4 = newvalue;
                    }
                }
                return NeonMenu.RedNeon4.ToString();
            }
            MenuDynamicListItem RedDynList4 = new MenuDynamicListItem("Red Back", "255", RedDyn4, "Set the red in RGB.");
            NeonColor.AddMenuItem(RedDynList4);
            // Red Dynamic List
            
            // Green Dynamic List
            string GreenDyn4(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.GreenNeon4 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.GreenNeon4 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.GreenNeon4 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.GreenNeon4 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.GreenNeon4 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.GreenNeon4 = newvalue;
                    }
                }
                return NeonMenu.GreenNeon4.ToString();
            }
            MenuDynamicListItem GreenDynList4 = new MenuDynamicListItem("Green Back", "255", GreenDyn4, "Set the Green in RGB.");
            NeonColor.AddMenuItem(GreenDynList4);
            // Green Dynamic List
            
            // Blue Dynamic List
            string BlueDyn4(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = NeonMenu.BlueNeon4 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = NeonMenu.BlueNeon4 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        NeonMenu.BlueNeon4 = newvalue;
                    }
                }
                else
                {
                    var newvalue = NeonMenu.BlueNeon4 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = NeonMenu.BlueNeon4 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        NeonMenu.BlueNeon4 = newvalue;
                    }
                }
                return NeonMenu.BlueNeon4.ToString();
            }
            MenuDynamicListItem BlueDynList4 = new MenuDynamicListItem("Blue Back", "0", BlueDyn4, "Set the Blue in RGB.");
            NeonColor.AddMenuItem(BlueDynList4);
            // Blue Dynamic List
            #endregion
            
            /*
            ########################################################
                                Event handlers
            ########################################################
            */
            
            NeonColor.OnDynamicListItemSelect += (_menu, _dynamicListItem, _currentItem) =>
            {
                // Code in here would get executed whenever a dynamic list item is pressed.
                if (MainMenu.DebugMode == true)
                {
                    Debug.WriteLine($"OnDynamicListItemSelect: [{_menu}, {_dynamicListItem}, {_currentItem}]");
                }

                if (_dynamicListItem == RedDynList1)
                {
                    PaintInput(1, 1);
                }
                
                if (_dynamicListItem == GreenDynList1)
                {
                    PaintInput(2, 2);
                }
                
                if (_dynamicListItem == BlueDynList1)
                {
                    PaintInput(3, 3);
                }
                
                if (_dynamicListItem == RedDynList2)
                {
                    PaintInput(1, 4);
                }
                
                if (_dynamicListItem == GreenDynList2)
                {
                    PaintInput(2, 5);
                }
                
                if (_dynamicListItem == BlueDynList2)
                {
                    PaintInput(3, 6);
                }
                
                if (_dynamicListItem == RedDynList3)
                {
                    PaintInput(1, 7);
                }
                
                if (_dynamicListItem == GreenDynList3)
                {
                    PaintInput(2, 8);
                }
                
                if (_dynamicListItem == BlueDynList3)
                {
                    PaintInput(3, 9);
                }
                
                if (_dynamicListItem == RedDynList4)
                {
                    PaintInput(1, 10);
                }
                
                if (_dynamicListItem == GreenDynList4)
                {
                    PaintInput(2, 11);
                }
                
                if (_dynamicListItem == BlueDynList4)
                {
                    PaintInput(3, 12);
                }
            };
        }
        
        #region PaintInput
        public async void PaintInput(int Type, int Color)
        {
            string result = await Functions.GetUserInput(windowTitle: "Enter a number between 0 and 255", maxInputLength: 3);

            if (!string.IsNullOrEmpty(result))
            {
                int resultint = 0;
                Int32.TryParse(result, out resultint);

                #region Debug
                if (MainMenu.DebugMode == true)
                {
                    if (Color == 1)
                    {
                        Debug.Write($"Result:{resultint}/RedRGB:{NeonMenu.RedNeon1}");
                    }
                    if (Color == 2)
                    {
                        Debug.Write($"Result:{resultint}/Green:{NeonMenu.GreenNeon1}");
                    }
                    if (Color == 3)
                    {
                        Debug.Write($"Result:{resultint}/BlueRGB:{NeonMenu.BlueNeon1}");
                    }
                    if (Color == 4)
                    {
                        Debug.Write($"Result:{resultint}/RedRGB:{NeonMenu.RedNeon2}");
                    }
                    if (Color == 5)
                    {
                        Debug.Write($"Result:{resultint}/Green:{NeonMenu.GreenNeon2}");
                    }
                    if (Color == 6)
                    {
                        Debug.Write($"Result:{resultint}/BlueRGB:{NeonMenu.BlueNeon2}");
                    }
                    if (Color == 7)
                    {
                        Debug.Write($"Result:{resultint}/RedRGB:{NeonMenu.RedNeon3}");
                    }
                    if (Color == 8)
                    {
                        Debug.Write($"Result:{resultint}/Green:{NeonMenu.GreenNeon3}");
                    }
                    if (Color == 9)
                    {
                        Debug.Write($"Result:{resultint}/BlueRGB:{NeonMenu.BlueNeon3}");
                    }
                    if (Color == 10)
                    {
                        Debug.Write($"Result:{resultint}/RedRGB:{NeonMenu.RedNeon4}");
                    }
                    if (Color == 11)
                    {
                        Debug.Write($"Result:{resultint}/Green:{NeonMenu.GreenNeon4}");
                    }
                    if (Color == 12)
                    {
                        Debug.Write($"Result:{resultint}/BlueRGB:{NeonMenu.BlueNeon4}");
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
                    if (Color == 1)
                    {
                        NeonMenu.RedNeon1 = resultint;
                    }
                    if (Color == 2)
                    {
                        NeonMenu.GreenNeon1 = resultint;
                    }
                    if (Color == 3)
                    {
                        NeonMenu.BlueNeon1 = resultint;
                    }
                    
                    if (Color == 4)
                    {
                        NeonMenu.RedNeon2 = resultint;
                    }
                    if (Color == 5)
                    {
                        NeonMenu.GreenNeon2 = resultint;
                    }
                    if (Color == 6)
                    {
                        NeonMenu.BlueNeon2 = resultint;
                    }
                    
                    if (Color == 7)
                    {
                        NeonMenu.RedNeon3 = resultint;
                    }
                    if (Color == 8)
                    {
                        NeonMenu.GreenNeon3 = resultint;
                    }
                    if (Color == 9)
                    {
                        NeonMenu.BlueNeon3 = resultint;
                    }
                    
                    if (Color == 10)
                    {
                        NeonMenu.RedNeon4 = resultint;
                    }
                    if (Color == 11)
                    {
                        NeonMenu.GreenNeon4 = resultint;
                    }
                    if (Color == 12)
                    {
                        NeonMenu.BlueNeon4 = resultint;
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
            if (NeonColor == null)
            {
                CreateMenu();
            }
            return NeonColor;
        }
    }
}