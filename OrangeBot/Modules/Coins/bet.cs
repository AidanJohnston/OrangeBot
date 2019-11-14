using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    
    public class bet : ModuleBase<SocketCommandContext>
    {

        Random rand = new Random();

        [Command("bet"), Alias("gamble")]
        public async Task gamble(string amount)
        {
            string path = "C:\\Users\\Aidan Johnsotn\\Desktop\\coins\\";

            if (!File.Exists($"{path}{Context.User.Username}.txt"))
            {
                await ReplyAsync($"Hey, you have not started a coin bank yet.  You can start one with !coinstart");
            }
            else
            {   //Read current user balance
                int balance = int.Parse((await File.ReadAllTextAsync($"{path}{Context.User.Username}.txt")).Trim());

                //Convert user bet amount to int, will fail if string contains anything other than a number
                int amount_int;
                bool isNumerical = int.TryParse(amount, out amount_int);

                //Check if amount_int is vaild number ( number != 0, number  < 0)
                if (amount_int == 0)        await ReplyAsync("You can't bet that many coin dummie");
                if (amount_int > balance)   await ReplyAsync("You don't even have that many coins.");
                if (amount_int > 0 && amount_int <= balance)
                {


                    int ran = rand.Next(0, 100);


                    //51% to win
                    if (ran > 45)                 
                    {

                        //New balance amount after winning the bet picks random number between 100% and 150% of bet amount

                        int amountwon = amount_int / 2 + rand.Next((amount_int / 2) + 1, amount_int + 2);

                        balance = amountwon + balance;
                        
                        //Convert to string
                        string balance_string = balance.ToString();

                        //Input value in text file
                        await File.WriteAllTextAsync($"{path}{Context.User.Username}.txt", balance_string);

                        //Print out info on bet
                        EmbedBuilder builder = new EmbedBuilder();
                        builder.AddField($"Aw shucks, you won {amountwon}", $"New balance is {balance}")
                               .WithColor(Color.Orange);
                        await ReplyAsync("", false, builder.Build());
                    }

                    else
                    {
                        //Amount lost, chose the loss amount to be between 75% of and 100$ of bet
                        int amountlost = 3 * (amount_int / 4) + rand.Next(1, (amount_int / 4) + 1);

                        
                        balance = balance - amountlost;

                        //Bank acount cant go below 0
                        if (balance < 0) balance = 0;

                       //Converting balance to string
                        string balance_string = balance.ToString();
                        
                        //Inputing new string in file
                        await File.WriteAllTextAsync($"{path}{Context.User.Username}.txt", balance.ToString());

                        //Printing info
                        EmbedBuilder builder = new EmbedBuilder();
                        builder.AddField($"Heck yeah, you lost {amountlost} coins", $"New balance is {balance}")
                               .WithColor(Color.Orange);
                        await ReplyAsync("", false, builder.Build());
                    }

                }
            }
        }
    }
}