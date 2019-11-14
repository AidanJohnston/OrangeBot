/*using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class copypasta : ModuleBase<SocketCommandContext>
    {
        [Command("copypasta")] // second word of command
        public async Task copy()
        {

            var rand = new Random();
            var files = Directory.GetFiles("C:\\Users\\Aidan Johnsotn\\Dropbox\\IFTTT\\reddit\\copypasta");



            //Generating random number that favors being closer to 0;
            int i = rand.Next(files.Length);

            //Printing out random number in console
            Console.WriteLine(i);

            //Set message to contence of file, convert to type int
            string message = File.ReadAllText(files[i]);

            if (message.Length < 2000)
            {
                Console.WriteLine("Message is shorter than 2000");
                EmbedBuilder builder = new EmbedBuilder();
                builder.WithTitle(Path.GetFileNameWithoutExtension(files[i]))
                       .WithDescription(message)
                       .WithFooter($"Requested by: {Context.User.Username}")
                       .WithColor(Color.Orange);


                await ReplyAsync("", false, builder.Build());
            }

            if (message.Length >= 2000)
            {
                Console.WriteLine($"Message is longer than 2000, message length is {message.Length}");
                var result = SplitBy(message, 2000);

                

                EmbedBuilder first = new EmbedBuilder();
                first.WithTitle(Path.GetFileNameWithoutExtension(files[i]))
                     .WithDescription($"{result.First()}")
                     .WithColor(Color.Orange);
                await ReplyAsync("", false, first.Build());

                for (int w = 1; w < 1; w++)
                {
                    EmbedBuilder mid = new EmbedBuilder();
                    first.WithDescription($"{message[1]}")
                         .WithColor(Color.Orange);
                    await ReplyAsync("", false, mid.Build());

                }

                EmbedBuilder last = new EmbedBuilder();
                first.WithDescription($"{message.Last()}")
                     .WithFooter($"Requested by: {Context.User.Username}")
                     .WithColor(Color.Orange);
                await ReplyAsync("", false, last.Build());
                
            }


        }
        public IEnumerable<string> SplitBy(this string str, int chunkLength)
        {
            
            for (int i = 0; i < str.Length; i += chunkLength)
            {
                if (chunkLength + i > str.Length)
                    chunkLength = str.Length - i;

               return str.Substring(i, chunkLength);
            }
        }
    }
}
*/