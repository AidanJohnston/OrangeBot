using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class give : ModuleBase<SocketCommandContext>
    {

        

        [Command("give")]
        public async Task give_pls(string username, int val)
        {
            string path = "C:\\Users\\Aidan Johnsotn\\Desktop\\coins\\";


            //Check if user has started coin bank
            if (File.Exists($"{path}{Context.User.Username}.txt"))
            {
                //Check if person 
                if (File.Exists($"{path}{username}.txt"))
                {
                    int donator_balance = int.Parse((await File.ReadAllTextAsync($"{path}{Context.User.Username}.txt")).Trim());

                    int receivor_balance = int.Parse((await File.ReadAllTextAsync($"{path}{username}.txt")).Trim());

                    if (val == 0) await ReplyAsync("You can't give zero coins dummie");
                    if (val < 0) await ReplyAsync("You can't give negative coins");
                    if (val > donator_balance) await ReplyAsync("You don't even have that many coins.");
                    if (val > 0 && val <= donator_balance)
                    {
                        receivor_balance = receivor_balance + val;
                        donator_balance = donator_balance - val;

                        string recivor_balance_string = receivor_balance.ToString();
                        string donator_balance_string = donator_balance.ToString();

                        await File.WriteAllTextAsync($"{path}{Context.User.Username}.txt", donator_balance_string);
                        await File.WriteAllTextAsync($"{path}{username}.txt", recivor_balance_string);

                        EmbedBuilder builder = new EmbedBuilder();
                        builder.WithTitle($"{Context.User.Username} gave {val} coins to {username}")
                               .AddField($"{Context.User.Username}", $"Balance: {donator_balance}")
                               .AddField($"{username}", $"Balance: {receivor_balance}")
                               .WithColor(Color.Orange);

                        await ReplyAsync("", false, builder.Build());
                        
                    }
                }
                else await ReplyAsync($"The person {username} doesnt apear to have started collecting coins yet.  Did you spell their name right?");
            }
            else await ReplyAsync($"Hey, you have not started a coin bank yet.  You can start one with !coinstart");

        }
    }
}