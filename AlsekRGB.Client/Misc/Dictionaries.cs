using System.Collections.Generic;
using CitizenFX.Core;
using Newtonsoft.Json;
using static CitizenFX.Core.Native.API;

namespace AlsekRGB.Client
{
    public class Dictionaries
    {
        public static bool firstTick = true;
        
        public static List<string> LangMain = new List<string>();
        public static List<string> LangPaint = new List<string>();
        public static List<string> LangNeon = new List<string>();

        public static void LoadDic()
        {
            if (firstTick)
            {
                firstTick = false;

                string jsonDataMain = LoadResourceFile(GetCurrentResourceName(), MainMenu.LanguageSupport) ?? "{}";
                try
                {
                    // load new locations.
                    var langs = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonDataMain);

                    // load locations
                    if (langs.ContainsKey("Main"))
                    {
                        foreach (string lang in langs["Main"])
                        {
                            if (!LangMain.Contains(lang))
                            {
                                //Debug.Write($"TESTY:::{lang}");
                                LangMain.Add(lang);
                            }
                            else
                                Debug.WriteLine(
                                    $"[AlsekNPC] Your language file contains 2 or more entries with the same vehicle name! ({lang}) Please remove duplicate lines!");
                        }
                    }
                }
                catch (JsonReaderException ex)
                {
                    Debug.WriteLine(
                        $"\n\n^1[AlsekNPC] ^7Your language file contains a problem! Error details: {ex.Message}\n\n");
                }
                
                string jsonDataPaint = LoadResourceFile(GetCurrentResourceName(), MainMenu.LanguageSupport) ?? "{}";
                try
                {
                    // load new locations.
                    var langs = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonDataPaint);

                    // load locations
                    if (langs.ContainsKey("Paint"))
                    {
                        foreach (string lang in langs["Paint"])
                        {
                            if (!LangPaint.Contains(lang))
                            {
                                //Debug.Write($"TESTY:::{lang}");
                                LangPaint.Add(lang);
                            }
                            else
                                Debug.WriteLine(
                                    $"[AlsekNPC] Your language file contains 2 or more entries with the same vehicle name! ({lang}) Please remove duplicate lines!");
                        }
                    }
                }
                catch (JsonReaderException ex)
                {
                    Debug.WriteLine(
                        $"\n\n^1[AlsekNPC] ^7Your language file contains a problem! Error details: {ex.Message}\n\n");
                }
                
                string jsonDataNeon = LoadResourceFile(GetCurrentResourceName(), MainMenu.LanguageSupport) ?? "{}";
                try
                {
                    // load new locations.
                    var langs = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonDataNeon);

                    // load locations
                    if (langs.ContainsKey("Neon"))
                    {
                        foreach (string lang in langs["Neon"])
                        {
                            if (!LangNeon.Contains(lang))
                            {
                                //Debug.Write($"TESTY:::{lang}");
                                LangNeon.Add(lang);
                            }
                            else
                                Debug.WriteLine(
                                    $"[AlsekNPC] Your language file contains 2 or more entries with the same vehicle name! ({lang}) Please remove duplicate lines!");
                        }
                    }
                }
                catch (JsonReaderException ex)
                {
                    Debug.WriteLine(
                        $"\n\n^1[AlsekNPC] ^7Your language file contains a problem! Error details: {ex.Message}\n\n");
                }
            }
        }
    }
}