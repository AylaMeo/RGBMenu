using CitizenFX.Core;
using CitizenFX.Core.UI;
using MenuAPI;

namespace AlsekRGB.Client
{
    public class NeonChanger
    {
        private Menu NeonColor;

        public int RedNeon1 = 222;
        public int GreenNeon1 = 222;
        public int BlueNeon1 = 255;
        
        public int RedNeon2 = 3;
        public int GreenNeon2 = 83;
        public int BlueNeon2 = 255;
        
        public int RedNeon3 = 0;
        public int GreenNeon3 = 250;
        public int BlueNeon3 = 140;
        
        public int RedNeon4 = 255;
        public int GreenNeon4 = 255;
        public int BlueNeon4 = 0;

        private void CreateMenu()
        {
            NeonColor = new Menu("Neon Colors", "Neon tuning");

            #region Neon1
            // Red Dynamic List
            string RedDyn1(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = RedNeon1 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = RedNeon1 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Red~w~ is 0");
                        }
                    }
                    else
                    {
                        RedNeon1 = newvalue;
                    }
                }
                else
                {
                    var newvalue = RedNeon1 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = RedNeon1 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Red~w~ is 255");
                        }
                    }
                    else
                    {
                        RedNeon1 = newvalue;
                    }
                }
                return RedNeon1.ToString();
            }
            MenuDynamicListItem RedDynList1 = new MenuDynamicListItem("Red Left", "222", RedDyn1, "Set the red in RGB.");
            NeonColor.AddMenuItem(RedDynList1);
            // Red Dynamic List
            
            // Green Dynamic List
            string GreenDyn1(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = GreenNeon1 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = GreenNeon1 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        GreenNeon1 = newvalue;
                    }
                }
                else
                {
                    var newvalue = GreenNeon1 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = GreenNeon1 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        GreenNeon1 = newvalue;
                    }
                }
                return GreenNeon1.ToString();
            }
            MenuDynamicListItem GreenDynList1 = new MenuDynamicListItem("Green Left", "222", GreenDyn1, "Set the Green in RGB.");
            NeonColor.AddMenuItem(GreenDynList1);
            // Green Dynamic List
            
            // Blue Dynamic List
            string BlueDyn1(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = BlueNeon1 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = BlueNeon1 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        BlueNeon1 = newvalue;
                    }
                }
                else
                {
                    var newvalue = BlueNeon1 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = BlueNeon1 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        BlueNeon1 = newvalue;
                    }
                }
                return BlueNeon1.ToString();
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
                    var newvalue = RedNeon2 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = RedNeon2 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Red~w~ is 0");
                        }
                    }
                    else
                    {
                        RedNeon2 = newvalue;
                    }
                }
                else
                {
                    var newvalue = RedNeon2 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = RedNeon2 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Red~w~ is 255");
                        }
                    }
                    else
                    {
                        RedNeon2 = newvalue;
                    }
                }
                return RedNeon2.ToString();
            }
            MenuDynamicListItem RedDynList2 = new MenuDynamicListItem("Red Front", "3", RedDyn2, "Set the red in RGB.");
            NeonColor.AddMenuItem(RedDynList2);
            // Red Dynamic List
            
            // Green Dynamic List
            string GreenDyn2(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = GreenNeon2 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = GreenNeon2 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        GreenNeon2 = newvalue;
                    }
                }
                else
                {
                    var newvalue = GreenNeon2 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = GreenNeon2 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        GreenNeon2 = newvalue;
                    }
                }
                return GreenNeon2.ToString();
            }
            MenuDynamicListItem GreenDynList2 = new MenuDynamicListItem("Green Front", "83", GreenDyn2, "Set the Green in RGB.");
            NeonColor.AddMenuItem(GreenDynList2);
            // Green Dynamic List
            
            // Blue Dynamic List
            string BlueDyn2(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = BlueNeon2 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = BlueNeon2 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        BlueNeon2 = newvalue;
                    }
                }
                else
                {
                    var newvalue = BlueNeon2 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = BlueNeon2 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        BlueNeon2 = newvalue;
                    }
                }
                return BlueNeon2.ToString();
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
                    var newvalue = RedNeon3 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = RedNeon3 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Red~w~ is 0");
                        }
                    }
                    else
                    {
                        RedNeon3 = newvalue;
                    }
                }
                else
                {
                    var newvalue = RedNeon3 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = RedNeon3 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Red~w~ is 255");
                        }
                    }
                    else
                    {
                        RedNeon3 = newvalue;
                    }
                }
                return RedNeon3.ToString();
            }
            MenuDynamicListItem RedDynList3 = new MenuDynamicListItem("Red Right", "0", RedDyn3, "Set the red in RGB.");
            NeonColor.AddMenuItem(RedDynList3);
            // Red Dynamic List
            
            // Green Dynamic List
            string GreenDyn3(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = GreenNeon3 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = GreenNeon3 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        GreenNeon3 = newvalue;
                    }
                }
                else
                {
                    var newvalue = GreenNeon3 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = GreenNeon3 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        GreenNeon3 = newvalue;
                    }
                }
                return GreenNeon3.ToString();
            }
            MenuDynamicListItem GreenDynList3 = new MenuDynamicListItem("Green Right", "250", GreenDyn3, "Set the Green in RGB.");
            NeonColor.AddMenuItem(GreenDynList3);
            // Green Dynamic List
            
            // Blue Dynamic List
            string BlueDyn3(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = BlueNeon3 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = BlueNeon3 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        BlueNeon3 = newvalue;
                    }
                }
                else
                {
                    var newvalue = BlueNeon3 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = BlueNeon3 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        BlueNeon3 = newvalue;
                    }
                }
                return BlueNeon3.ToString();
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
                    var newvalue = RedNeon4 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = RedNeon4 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Red~w~ is 0");
                        }
                    }
                    else
                    {
                        RedNeon4 = newvalue;
                    }
                }
                else
                {
                    var newvalue = RedNeon4 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = RedNeon4 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Red~w~ is 255");
                        }
                    }
                    else
                    {
                        RedNeon4 = newvalue;
                    }
                }
                return RedNeon4.ToString();
            }
            MenuDynamicListItem RedDynList4 = new MenuDynamicListItem("Red Back", "255", RedDyn4, "Set the red in RGB.");
            NeonColor.AddMenuItem(RedDynList4);
            // Red Dynamic List
            
            // Green Dynamic List
            string GreenDyn4(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = GreenNeon4 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = GreenNeon4 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        GreenNeon4 = newvalue;
                    }
                }
                else
                {
                    var newvalue = GreenNeon4 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = GreenNeon4 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        GreenNeon4 = newvalue;
                    }
                }
                return GreenNeon4.ToString();
            }
            MenuDynamicListItem GreenDynList4 = new MenuDynamicListItem("Green Back", "255", GreenDyn4, "Set the Green in RGB.");
            NeonColor.AddMenuItem(GreenDynList4);
            // Green Dynamic List
            
            // Blue Dynamic List
            string BlueDyn4(MenuDynamicListItem item, bool left)
            {
                if (left)
                {
                    var newvalue = BlueNeon4 - 1;
                    if (newvalue < 0)
                    {
                        newvalue = BlueNeon4 = 255;
                        
                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Min value allowed for ~b~Green~w~ is 0");
                        }
                    }
                    else
                    {
                        BlueNeon4 = newvalue;
                    }
                }
                else
                {
                    var newvalue = BlueNeon4 + 1;
                    if (newvalue > 255)
                    {
                        newvalue = BlueNeon4 = 0;

                        if (MainMenu.DebugMode == true)
                        {
                            Screen.ShowNotification($"AlsekRGB: Max value allowed for ~b~Green~w~ is 255");
                        }
                    }
                    else
                    {
                        BlueNeon4 = newvalue;
                    }
                }
                return BlueNeon4.ToString();
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
        }
        
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