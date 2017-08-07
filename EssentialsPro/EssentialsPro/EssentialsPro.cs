
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
        protected override void OnEnable()
        {
            RegisterCommands();
        }

        public override void OnDisable()
        {

        }

        private void RegisterCommands()
        {
            Context.PluginManager.LoadCommands(new Clear(this));
        }
    }
}
