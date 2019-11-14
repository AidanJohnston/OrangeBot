using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{





    public class quote : ModuleBase<SocketCommandContext>
    {
        Random rand; //Create random number gen

        [Command("quote")] // First word of command
        public async Task BC9quote()
        {
            rand = new Random(); // Generate random number
            string[] freshquote; // Create array of string
            freshquote = new string[]
            {
                    "\"I'm popping off\" - DG06",
                    "\"Skate fast eat ass\" - OrangeLube",
                    "\"I am a person who isn't bald for sure.  100% certain\" - Enum",
                    "\"I have a ball over here for you\" - Orange",
                    "\"Can you carry me in my placements dog?\" - Spearslim",
                    "\"You just have to not be a dumbass\" - Enum",
                    "\"I spent 60 dollars on this game and I'm not allowed to play it\" - Sunny78",
                    "\"Can you sub for our next 20 games\" - Gash",
                    "\"Did someone say peanut butter\" - Cynosure", 
                    "\"Music major BTW\" - Cynosure",
                    "\"Psych major BTW\" - Cynosure",
                    "\"Ahhhhhhhhhhhh\" - Cynosure",
                    "\"I'm going to the beach\" - DG06",
                    "\"I could dunk on you\" - DG06",
                    "\"REIN REIN REIN\" - Cynosure",
                    "\"Spear get the fuck back\" - Enum",
                    "\"pls boobs\" - Cynosure",
                    "\"That's real fishy.... \" - Raid team 6",
                    "\"THATS NOT DIAMOND POSITIONING\" - Raid team 6",
                    "\"he's turning the aimbot on and off so we don't notice\" - Rain team 6",
                    "\"\" - Sequoia",
                    "\"DOG GET THE FUCK BEHIND MY SHIELD\" - anonymous",
                    "\"Running through hoes, cycling through pre-workout, and swimming in pussy.\" - Martti",
                    "\"Bananas are digital and all other fruit are analog\" - Martti",
                    "\"😡\" - Sunny",
                    "\"Running through hoes, cycling through pre-workout, and swimming in pussy.\" - Martti",
                    "\"Bananas are digital and all other fruit are analog\" - Martti",
                    "\"I will leave and make a new one, that supports bilingualism and everyone from this server will join and leave this one\" - Martti",
                    "\"You want to talk commie? go to another server\" - Sunny78",
                    "\"I thought mine was big, but then she took off her pants\" - DG06",
                    "\"I'm not wearing any pants\" - Yukali",
                    "\"Fight in the courtyard\" - Yukali",
                    "\"Don't sleep on my boi Profit\" - Sequoia",
                    "\"I'm no goddamn coward\" - Enum",
                    "\"I'm retarded but at least I'm not a coward\" - Cynosure",
                    "\"The enemy has blade. Don't ask me how I know\" - Cynosure",
                    "\"This quote is brought to you by Sprite\" - Sunny78",
                    "\"I'm a junkrat one trick\" - DG06",
                    "\"No aim no brain Winston main btw\" - Cynosure",
                    "\"You guys blew all your ults on that fight\" - Yukali",
                    "\"Sorry I have something at 7\" - Cynosure",
                    "\"Does anyone want to play goodnite with me\" - Spearslim",
                    "\"rude\" - OrangeLube",
            };

            //Random event,  1/20 chance of happening
            int ran = rand.Next(20);
            if (ran == 1)
            {
                await ReplyAsync($"Damm {Context.User.Username} I'd sure love to gobble up that thicc and tight bootie hole of yours.");
                await Task.Delay(4000);  //Wait 4 seconds
                await ReplyAsync($"Shit");
                await Task.Delay(3000);  //Wait 3 seconds
                await ReplyAsync($"I didnt mean to say that");
                await Task.Delay(2500);  //Wait 2.5 seconds
            }
            //print one of the string from array
            await ReplyAsync(freshquote[rand.Next(freshquote.Length)]);
        }

    }
}
