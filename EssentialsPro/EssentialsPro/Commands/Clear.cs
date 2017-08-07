
using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using MiNET.Utils;

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

namespace EssentialsPro.Commands
{
    public class Clear
    {
        private EssentialsPro Plugin { get; set; }

        public Clear(EssentialsPro plugin)
        {
            plugin = Plugin;
        }

        [Command(Name = "clear", Description = "Clears your inventory.", Permission = "essentialspro.commands.clear")]
        public void Execute(Player sender)
        {
            sender.Inventory.Clear();

            sender.SendMessage(ChatColors.Green + "Your inventory was cleared successfully.");
        }
    }
}
