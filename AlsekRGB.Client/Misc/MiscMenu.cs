using MenuAPI;
using CitizenFX.Core;

namespace AlsekRGB.Client
{
    public class MiscMenu
    {
        private Menu Misc;
        
        private void CreateMenu()
        {
            Misc = new Menu("Miscellaneous", "Miscellaneous stuff");
            
            MenuCheckboxItem Align = new MenuCheckboxItem("Right Align Menu", "This will change the menu to appear on the left", !Misc.LeftAligned)
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            Misc.AddMenuItem(Align);
            /*
            MenuCheckboxItem DebugMode = new MenuCheckboxItem("Debug Mode", "This will enable debug mode", MainMenu.DebugMode)
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            Misc.AddMenuItem(DebugMode);
            */
            // Credits
            Misc.AddMenuItem(new MenuItem("Made using MenuAPI by Vespura", "Full credit to him otherwise this wouldn't be possible! <3"));
                  
            /*
            ########################################################
                                Event handlers
            ########################################################
            */
            Misc.OnCheckboxChange += (_menu, _item, _index, _checked) =>
            {
                // Code in here gets executed whenever a checkbox is toggled.
                if (MainMenu.DebugMode == true)
                {
                    Debug.WriteLine($"OnCheckboxChange: [{_menu}, {_item}, {_index}, {_checked}]");
                }
                
                // If the align-menu checkbox is toggled, toggle the menu alignment.
                if (_item == Align)
                {
                    if (_checked)
                    {
                        MenuController.MenuAlignment = MenuController.MenuAlignmentOption.Right;
                    }
                    else
                    {
                        MenuController.MenuAlignment = MenuController.MenuAlignmentOption.Left;
                    }
                }
                
                /*
                if (_item == DebugMode)
                {
                    if (_checked)
                    {
                        MainMenu.DebugMode = true;
                    }
                    else
                    {
                        MainMenu.DebugMode = false;
                    }
                }*/
            };
        }
        
        public Menu GetMenu()
        {
            if (Misc == null)
            {
                CreateMenu();
            }
            return Misc;
        }
    }
}