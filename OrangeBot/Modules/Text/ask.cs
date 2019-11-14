using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
     
    public class ask : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        [Command("ask")] // second word of command
        public async Task one([Remainder]string ask)
        {
            
            //Generate random 50% change of 1, 2
            int ran = rand.Next(1, 3);
            if (ran == 1) await ReplyAsync("Yes");
            if (ran == 2) await ReplyAsync("No");
        }
    }
}
