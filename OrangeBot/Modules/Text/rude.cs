using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class rude : ModuleBase<SocketCommandContext>
    {
        

        [Command("rude")] // second word of command
        public async Task one()
        {

            await ReplyAsync("😡");
            
        }
    }
}
