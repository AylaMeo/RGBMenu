using MenuAPI;
using CitizenFX.Core;

namespace AlsekRGB.Client
{
    public class CommandMenu
    {
        private Menu Commands;

        private void CreateMenu()
        {
            Commands = new Menu("Command Menu", "List of commands");
            
            Commands.AddMenuItem(new MenuItem("/RGBPaint", "use this to specify the RGB of your paint. Example: 32,60,255 OR: 32/60/255"));
            
            Commands.AddMenuItem(new MenuItem("/NeonRate", "use this to specify the rate of your neons flashing Example: 322 OR: 50"));
            
            
            /*
            ########################################################
                                Event handlers
            ########################################################
            */
        }
        
        public Menu GetMenu()
        {
            if (Commands == null)
            {
                CreateMenu();
            }
            return Commands;
        }
    }
}