using MenuAPI;
using CitizenFX.Core;

namespace AlsekRGB.Client
{
    public class MiscMenu
    {
        private Menu menu;

        private void CreateMenu()
        {
            menu = new Menu("Miscellaneous", "Miscellaneous stuff");
            
            
            // Credits
            menu.AddMenuItem(new MenuItem("Made using MenuAPI by Vespura", "Full credit to him otherwise this wouldn't be possible! <3"));
            
            MenuCheckboxItem Align = new MenuCheckboxItem("Right Align Menu", "This will change the menu to appear on the left", !menu.LeftAligned)
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            menu.AddMenuItem(Align);
            
            MenuCheckboxItem DebugMode = new MenuCheckboxItem("Debug Mode", "This will enable debug mode", MainMenu.DebugMode)
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            menu.AddMenuItem(DebugMode);
            
            /*
            ########################################################
                                Event handlers
            ########################################################
            */
            menu.OnCheckboxChange += (_menu, _item, _index, _checked) =>
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
                }
            };
        }
        
        public Menu GetMenu()
        {
            if (menu == null)
            {
                CreateMenu();
            }
            return menu;
        }
    }
}