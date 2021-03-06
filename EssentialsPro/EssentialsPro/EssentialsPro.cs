﻿
using EssentialsPro.Commands;

using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;

/*
    ########  #### ########    ###    
    ##     ##  ##  ##         ## ##   
    ##     ##  ##  ##        ##   ##  
    ########   ##  ######   ##     ## 
    ##         ##  ##       ######### 
    ##         ##  ##       ##     ## 
    ##        #### ######## ##     ## 
    
    PIEA, MINET Developers' Team.
*/

namespace EssentialsPro
{
    [Plugin(PluginName = "EssentialsPro", Description = "Preparing...", PluginVersion = "1.0", Author = "PIEA")]
    public class EssentialsPro : Plugin
    {
        private EPMessages Message { get; set; }

        protected override void OnEnable()
        {
            Message = new EPMessages(this);

            RegisterCommands();
        }

        public override void OnDisable()
        {

        }

        private void RegisterCommands()
        {
            Context.PluginManager.LoadCommands(new Clear(this));
        }

        public string GetMessage(string type, string tags)
        {
            return Message.GetMessage(type, tags);
        }
    }
}
