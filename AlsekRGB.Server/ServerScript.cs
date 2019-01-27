using System;
using System.Collections.Generic;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace AlsekRGB.Server
{
    public class ServerScript : BaseScript
    {
        public ServerScript()
        {
            // constructor code
            API.RegisterCommand("ColorR", new Action<int, List<object>, string>((source, arguments, raw) =>
            {
                TriggerClientEvent(Players[source], "Alsek:Red");
            }), false);
            API.RegisterCommand("Color", new Action<int, List<object>, string>((source, arguments, raw) =>
            {
                TriggerClientEvent(Players[source], "Alsek:RedCon");
            }), false);
        }
    }
}
