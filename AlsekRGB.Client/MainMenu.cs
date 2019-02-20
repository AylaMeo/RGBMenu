using CitizenFX.Core;
using MenuAPI;

namespace AlsekRGB.Client
{
    public class MainMenu : BaseScript
    {   
        //Menu Variables
        public static bool DontOpenMenus { get { return MenuController.DontOpenAnyMenu; } set { MenuController.DontOpenAnyMenu = value; } }
        public static bool DisableControls { get { return MenuController.DisableMenuButtons; } set { MenuController.DisableMenuButtons = value; } }
        //Menu Variables
        
        public static NeonMenu Neon { get; private set; }
        public static PaintMenu Paint { get; private set; }
        public static MiscMenu Misc { get; private set; }
        public static bool DebugMode = false;

        public MainMenu()
        {
            Tick += NeonMenu.ProcessTask;
            
            MenuController.MenuToggleKey = Control.SelectCharacterMichael;
            MenuController.EnableMenuToggleKeyOnController = false;
                
            // Setting the menu alignment to be right aligned. This can be changed at any time and it'll update instantly.
            // To test this, checkout one of the checkbox items in this example menu. Clicking it will toggle the menu alignment.
            MenuController.MenuAlignment = MenuController.MenuAlignmentOption.Right;

            // Creating the first menu.
            Menu Color = new Menu("Color Menu", "By Alsekwolf") { Visible = true };
            MenuController.AddMenu(Color);

            //Adding the paint sub menu
            {
                Paint = new PaintMenu();
                Menu PaintMenu = Paint.GetMenu();
                MenuItem PaintButton = new MenuItem("Paint", "Painters place")
                {
                    Label = "→→→"
                };
                Color.AddMenuItem(PaintButton);
                MenuController.BindMenuItem(Color, PaintMenu, PaintButton);
            }
            
            //Adding the neon sub menu
            {
                Neon = new NeonMenu();
                Menu NeonMenu = Neon.GetMenu();
                MenuItem NeonButton = new MenuItem("Neons", "Neons are hot")
                {
                    Label = "→→→"
                };
                Color.AddMenuItem(NeonButton);
                MenuController.BindMenuItem(Color, NeonMenu, NeonButton);
            }
            
            //Adding the misc sub menu
            {
                Misc = new MiscMenu();
                Menu MiscMenu = Misc.GetMenu();
                MenuItem MiscButton = new MenuItem("Miscellaneous & Credits", "Miscellaneous stuff")
                {
                    Label = "→→→"
                };
                Color.AddMenuItem(MiscButton);
                MenuController.BindMenuItem(Color, MiscMenu, MiscButton);
            }
            
            /*
             ########################################################
                                 Event handlers
             ########################################################
            */

            Color.OnMenuClose += (_menu) =>
            {
                if (MainMenu.DebugMode == true)
                {
                    // Code in here gets triggered whenever the menu is closed.
                    Debug.WriteLine($"OnMenuClose: [{_menu}]");
                }

            };

            Color.OnMenuOpen += (_menu) =>
            {
                if (MainMenu.DebugMode == true)
                {
                    // Code in here gets triggered whenever the menu is opened.
                    Debug.WriteLine($"OnMenuOpen: [{_menu}]");
                }
            };  
        }
    }
}