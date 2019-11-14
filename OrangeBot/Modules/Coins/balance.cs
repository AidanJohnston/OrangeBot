using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class balance : ModuleBase<SocketCommandContext>
    {

        Random rand = new Random();

        [Command("balance")]
        public async Task gamble()
        {
            string path = "C:\\Users\\Aidan Johnsotn\\Desktop\\coins\\";

            if (!File.Exists($"{path}{Context.User.Username}.txt"))
            {
                await ReplyAsync($"Hey, you have not started a coin bank yet.  You can start one with !coinstart");
            }
            else
            {   //Read current user balance
                int balance = int.Parse((await File.ReadAllTextAsync($"{path}{Context.User.Username}.txt")).Trim());

                await ReplyAsync($"You have {balance} coins");
            }
        }
    }
}