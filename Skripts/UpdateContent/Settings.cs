using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacGame.Skripts.UpdateContent;

internal class Settings
{
    public bool OpenMenu { get; set; }
    public bool NewGame { get; set; }


    Settings() 
    {
        OpenMenu = true;
        NewGame = false;

    }


    public static Settings SettingsThis = new Settings();




}
