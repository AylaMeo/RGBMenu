using CitizenFX.Core;
using MenuAPI;
using static CitizenFX.Core.Native.API;

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
        public static bool DebugMode { get; private set; }
        public static bool FirstTick { get; private set; } = true;


        #region Lang

        #region MainMenu
        public static string MainMenuTitle { get; private set; }
        public static string PaintMenuTitle { get; private set; }
        public static string PaintMenuDesc { get; private set; }
        public static string NeonMenuTitle { get; private set; }
        public static string NeonMenuDesc { get; private set; }
        public static string MiscMenuTitle { get; private set; }
        public static string MiscMenuDesc { get; private set; }
        #endregion

        #region Paint Menu
        public static string PaintMenuPrimaryTitle { get; private set; }
        public static string PaintMenuPrimaryDesc { get; private set; }
        public static string PaintMenuSecondaryTitle { get; private set; }
        public static string PaintMenuSecondaryDesc { get; private set; }
        public static string PaintMenuRedTitle { get; private set; }
        public static string PaintMenuRedDesc { get; private set; }
        public static string PaintMenuBlueTitle { get; private set; }
        public static string PaintMenuBlueDesc { get; private set; }
        public static string PaintMenuGreenTitle { get; private set; }
        public static string PaintMenuGreenDesc { get; private set; }

        

        #endregion

        #endregion

        public MainMenu()
        {
            if (FirstTick)
            {
                FirstTick = false;
                if (GetResourceMetadata(GetCurrentResourceName(), "client_debug_mode", 0).ToLower() == "true")
                {
                    DebugMode = true; 
                }
                else
                {
                    DebugMode = false;
                }


                MainMenuTitle = GetResourceMetadata(GetCurrentResourceName(), "MainMenuTitle", 0);
                PaintMenuTitle = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuTitle", 0);
                PaintMenuDesc = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuDesc", 0);
                NeonMenuTitle = GetResourceMetadata(GetCurrentResourceName(), "NeonMenuTitle", 0);
                NeonMenuDesc = GetResourceMetadata(GetCurrentResourceName(), "NeonMenuDesc", 0);
                MiscMenuTitle = GetResourceMetadata(GetCurrentResourceName(), "MiscMenuTitle", 0);
                MiscMenuDesc = GetResourceMetadata(GetCurrentResourceName(), "MiscMenuDesc", 0);
                
                PaintMenuPrimaryTitle = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuPrimaryTitle", 0);
                PaintMenuPrimaryDesc = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuPrimaryDesc", 0);
                PaintMenuSecondaryTitle = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuSecondaryTitle", 0);
                PaintMenuSecondaryDesc = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuSecondaryDesc", 0);
                PaintMenuRedTitle = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuRedTitle", 0);
                PaintMenuRedDesc = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuRedDesc", 0);
                PaintMenuBlueTitle = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuBlueTitle", 0);
                PaintMenuBlueDesc = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuBlueDesc", 0);
                PaintMenuGreenTitle = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuGreenTitle", 0);
                PaintMenuGreenDesc = GetResourceMetadata(GetCurrentResourceName(), "PaintMenuGreenDesc", 0);
            }
            

            Tick += NeonMenu.ProcessTask;
            
            MenuController.MenuToggleKey = Control.SelectCharacterMichael;
            MenuController.EnableMenuToggleKeyOnController = false;
                
            // Setting the menu alignment to be right aligned. This can be changed at any time and it'll update instantly.
            // To test this, checkout one of the checkbox items in this example menu. Clicking it will toggle the menu alignment.
            MenuController.MenuAlignment = MenuController.MenuAlignmentOption.Right;

            // Creating the first menu.
            Menu Color = new Menu($"{MainMenuTitle}", "By Alsekwolf") { Visible = true };
            MenuController.AddMenu(Color);

            //Adding the paint sub menu
            {
                Paint = new PaintMenu();
                Menu PaintMenu = Paint.GetMenu();
                MenuItem PaintButton = new MenuItem($"{PaintMenuTitle}", $"{PaintMenuDesc}")
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
                MenuItem NeonButton = new MenuItem($"{NeonMenuTitle}", $"{NeonMenuDesc}")
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
                MenuItem MiscButton = new MenuItem($"{MiscMenuTitle}", $"{MiscMenuDesc}")
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