using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class dankmeme : ModuleBase<SocketCommandContext>
    {
        [Command("dankmeme")] // second word of command
        public async Task one()
        {
            
                var rand = new Random();
                var files = Directory.GetFiles("C:\\Users\\Aidan Johnsotn\\Dropbox\\IFTTT\\reddit\\dankmemes");



                //Generating random number that favors being closer to 0;
                int i = rand.Next(files.Length);

                //Printing out random number in console
                Console.WriteLine($"Image number {i} selected");

                //Set message to contence of file, convert to type int
                string message = File.ReadAllText(files[i]);


                EmbedBuilder builder = new EmbedBuilder();
                builder.WithTitle(Path.GetFileNameWithoutExtension(files[i]))
                       .WithImageUrl(message)
                       .WithFooter($"Requested by: {Context.User.Username}")
                       .WithColor(Color.Orange);


                await ReplyAsync("", false, builder.Build());
        }
    }
}
