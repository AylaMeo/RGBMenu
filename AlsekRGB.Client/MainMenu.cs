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


        #region Lang

        #region MainMenu
        public static string MainMenuTitle { get; private set; }
        public static string PaintMenuTitle = "0";
        public static string PaintMenuDesc = "0";
        public static string NeonMenuTitle  = "0";
        public static string NeonMenuDesc  = "0";
        public static string MiscMenuTitle  = "0";
        public static string MiscMenuDesc  = "0";
        #endregion

        #region Paint Menu
        public static string PaintMenuPrimaryTitle  = "0";
        public static string PaintMenuPrimaryDesc  = "0";
        public static string PaintMenuSecondaryTitle  = "0";
        public static string PaintMenuSecondaryDesc  = "0";
        public static string PaintMenuRedTitle = "0";
        public static string PaintMenuRedDesc = "0";
        public static string PaintMenuBlueTitle = "0";
        public static string PaintMenuBlueDesc = "0";
        public static string PaintMenuGreenTitle = "0";
        public static string PaintMenuGreenDesc = "0";

        

        #endregion

        #endregion

        public MainMenu()
        {
            Dictionaries.LoadDic();
            Tick += NeonMenu.ProcessTask;
            
            MenuController.MenuToggleKey = Control.SelectCharacterMichael;
            MenuController.EnableMenuToggleKeyOnController = false;
                
            // Setting the menu alignment to be right aligned. This can be changed at any time and it'll update instantly.
            // To test this, checkout one of the checkbox items in this example menu. Clicking it will toggle the menu alignment.
            MenuController.MenuAlignment = MenuController.MenuAlignmentOption.Right;

            // Creating the first menu.
            Menu Color = new Menu($"{Dictionaries.LangMain[0]}", "By Alsekwolf") { Visible = false };
            MenuController.AddMenu(Color);

            //Adding the paint sub menu
            {
                Paint = new PaintMenu();
                Menu PaintMenu = Paint.GetMenu();
                MenuItem PaintButton = new MenuItem($"{Dictionaries.LangMain[1]}", $"{Dictionaries.LangMain[2]}")
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
                MenuItem NeonButton = new MenuItem($"{Dictionaries.LangMain[3]}", $"{Dictionaries.LangMain[4]}")
                {
                    Label = "→→→"
                };
                Color.AddMenuItem(NeonButton);
                MenuController.BindMenuItem(Color, NeonMenu, NeonButton);
            }
            
            //Adding the misc sub menu //
            {
                Misc = new MiscMenu();
                Menu MiscMenu = Misc.GetMenu();
                MenuItem MiscButton = new MenuItem($"{Dictionaries.LangMain[5]}", $"{Dictionaries.LangMain[5]}")
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