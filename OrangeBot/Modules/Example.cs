using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    [Group("example")] //First word of command
    public class Exampple : ModuleBase<SocketCommandContext>
    {
        [Command("one")] // second word of command
        public async Task one()
        {
            //Main logic for printing to chat
            await ReplyAsync($"one {Context.User.Username}");  //Short hand input of variables
          
        }

        [Command("two")] // Second word of command
        public async Task two()
        {
            //Example using discord Embed text
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("Title")
                   .WithDescription("Description")
                   .WithColor(Color.Orange);

            await ReplyAsync("", false, builder.Build()); 
        }                       
     
    }
}
