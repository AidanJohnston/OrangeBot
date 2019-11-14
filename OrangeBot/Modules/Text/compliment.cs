using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class compliment : ModuleBase<SocketCommandContext>
    {
        Random rand; // Random number class

        [Command("compliment")] // First word of command
        public async Task TheThiccestofCompliments()
        {
            rand = new Random(); // Generate random number
            string[] freshcompliment;

            //Array of Compliments
            freshcompliment = new string[]
            {
                    "You’re so smart! Why haven’t I thought of that before?",
                    "You look great in that outfit.",
                    "The dinner you cooked for us was delicious.",
                    "Your children are well - behaved and polite.",
                    "You look younger than your age.",
                    "Congratulations on your promotion!",
                    "You’re so good at managing your money. How do you do that?",
                    "I like the way you smile.",
                    "You’re so funny!",
                    "Thank you for being so thoughtful.",
                    "Did you lose some weight ? You look healthy.",
                    "I like you because you are a great listener.",
                    "You inspired me to become a better person.",
                    "I couldn’t have finished this project without your help.",
                    "You deserve that award.",
                    "I like your sense of style.",
                    "You are a strong, beautiful person.",
                    "Your hair looks amazing.",
                    "You smell good today.",
                    "This report you sent me was organized.It has everything I need.",
                    "I am honored to be your partner.",
                    "You are a wonderful friend.",
                    "You rock that shirt!",
                    "Good job!",
                    "I like your shoes.",
                    "You are early today.",
                    "I like the way you designed my website.",
                    "You have a lovely voice.",
                    "Your sweater looks nice.Where did you buy that ?",
                    "You cracked me up with that joke.",
                    "I love all of the photos you’ve taken.",
                    "You are a great husband.",
                    "That’s so awesome!",
                    "Have been working out lately ?",
                    "That’s so sweet of you.",
                    "How do you style your hair like that?",
                    "Can you teach me how to dance?",
                    "I am grateful for your presence.",
                    "I enjoy hanging out with you.",
                    "I like your pants.",
                    "You delivered that speech very well.",
                    "I couldn’t forget how you’ve helped our family.",
                    "Thank you for being there for me when I needed you the most.",
                    "I will recommend your service to my friends.",
                    "I’d like to share this dessert with you.",
                    "I enjoy travelling with you.",
                    "I miss your kisses and hugs!",
                    "I need you in my life.",
                    "You look so adorable in that costume.",
                    "I’ll never grow tired looking at your picture.",
                    "I’m sure you will do just fine.",
                    "You are an amazing mentor to me.",
                    "I am happy with the doctor you recommended to me.",
                    "You must be the life of the party.",
                    "You look even better without makeup.",
                    "Your arms are so strong.",
                    "Your kid is very smart.",
                    "Bless your beautiful and kind heart.",
                    "I am so grateful that you visited me here today.",
                    "I am surprised to realize you are so talented!",
                    "You make me happy.",
                    "You have a great taste in clothes.",
                    "I enjoy chatting with you.",
                    "I agree with your thoughts on this matter.",
                    "Good morning, beautiful!",
                    "Take a break!You deserve a vacation.",
                    "How do make your skin to look flawless and radiant?",
                    "I would love to meet you in person.",
                    "I look forward to work with you again.",
                    "Your ideas were brilliant.",
                    "Of course, I would choose you over my work.",
                    "I’m so happy you called me.",
                    "Nice nails!",
                    "I will be here to support you on your decisions.",
                    "That’s awesome!",
                    "You are one of a kind.",
                    "Let me give you a hug because you’re simply amazing.",
                    "You have an interesting career.",
                    "You have a cool family.",
                    "The flowers you gave me were beautiful.",
                    "I wouldn’t be as brave as you in that situation.",
                    "I like that new painting you bought.",
                    "I am mesmerized by your beauty.",
                    "You look cool in those boots." ,
                    "I like this new article you wrote.",
                    "Keep up the good work!",
                    "You make Accounting look so sexy!",
                    "You are one of the most reliable employees in this department.",
                    "Excellent work on the client presentation!",
                    "I am amazed how you can manage your home and still find time to look pretty.",
                    "If only I could use you as my model.",
                    "How do you keep your cool even when everything around you is so stressful ?",
                    "You can have my food.I know this is your favorite.",
                    "You nailed it!",
                    "My dog even likes you.",
                    "You have the most infectious laugh ever!",
                    "Don’t worry too much. I know you will ace that exam.",
                    "I believe in you.",
                    "You complete me.",
                    "You are a skilled artist."
            };

            //Random event, 1/20 chance of happening
            int ran = rand.Next(20);
            if (ran == 1)
            {
                await ReplyAsync($"Damm {Context.User.Username} I'd really love to go to pound town on you right about now.  I'd gobble up your tight bootie hole.");
                await Task.Delay(4000);
                await ReplyAsync($"Shit");
                await Task.Delay(3000);
                await ReplyAsync($"I didnt mean to say that");
                await Task.Delay(2500);
            }

            //Print random string from array
            await ReplyAsync(freshcompliment[rand.Next(freshcompliment.Length)]);
        }
      
    }
}
