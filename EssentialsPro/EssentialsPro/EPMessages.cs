
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
    public class EPMessages
    {
        private EssentialsPro Plugin { get; set; }

        public EPMessages(EssentialsPro plugin)
        {
            Plugin = plugin;
        }

        public string GetMessage(string type, string tags)
        {
            return "";
        }
    }
}
