using Discord;
using Discord.Commands;
using Discord.Rest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class beg : ModuleBase<SocketCommandContext>
    {
       
        Random rand = new Random();

        [Command("beg")]
        public async Task beg_pls()
        {
            string path = "C:\\Users\\Aidan Johnsotn\\Desktop\\coins\\";

            if (!File.Exists($"{path}{Context.User.Username}.txt"))
            {
                await ReplyAsync($"Hey, you have not started a coin bank yet.  You can start one with !coinstart");
            }
            else
            {   //Read current user balance
                int balance = int.Parse((await File.ReadAllTextAsync($"{path}{Context.User.Username}.txt")).Trim());

                if (balance > 100) await ReplyAsync("You can only beg if you have less than 100 coins");
                else
                {
                    //Give user between 1 and 10 coins
                    int ran = rand.Next(1, 10);
                    balance = balance + ran;

                    //Convert blance to string
                    string balance_string = balance.ToString();

                    //Input new balance
                    await File.WriteAllTextAsync($"{path}{Context.User.Username}.txt", balance_string);

                    //Print new balance
                    await ReplyAsync($"Fine heres some coins");

                    //Build Embed Text
                    EmbedBuilder builder = new EmbedBuilder();
                    builder.AddField($"You got {ran} coins", $"You now have {balance}")
                          .WithColor(Color.Orange);
                    //Print to user
                    await ReplyAsync("", false, builder.Build());
                }
            }
        }
    }
}