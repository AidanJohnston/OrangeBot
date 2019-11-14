using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    
    public class coinstart : ModuleBase<SocketCommandContext>
    {
        [Command("coinstart")]
        public async Task coin_start()
        {
            string path = "C:\\Users\\Aidan Johnsotn\\Desktop\\coins\\";

            if (!File.Exists($"{path}{Context.User.Username}.txt"))
            {
                



                await File.AppendAllTextAsync($"{path}{Context.User.Username}.txt", "1000" );

                await ReplyAsync($"Created a coin bank for {Context.User.Username}.  I'm giving you a starting grant of 1000 coins.  Spend them wisely.");

            }
            else await ReplyAsync("You already have started a coin bank silly.  One acount is enough 🤔");
                


        }
    }
}