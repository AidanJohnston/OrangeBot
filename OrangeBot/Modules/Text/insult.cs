using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{





    public class insult : ModuleBase<SocketCommandContext>
    {
       Random rand;

      [Command("insult")]
      public async Task TheThiccestofInsults()
        {
            rand = new Random();
            string[] freshinsult;
            freshinsult = new string[]
            {
                    "Your aim is so bad you can't even build the torb turret." ,
                    "Your aim is so bad, even Cynosure would win in a Genji 1v1." ,
                    "Do you still love nature, despite what it did to you?" ,
                    "Is your ass jealous of the amount of shit that just came out of your mouth?",
                    "Your IQ’s lower than your shoe size." ,
                    "I could say nice things about you, but I’d rather tell the truth." ,
                    "If opposites attract, then I hope you meet someone who is attractive, honest, intelligent, and cultured.",
                    "Do you hear that? It’s the sound of no one caring.",
                    "You should have been born in the Dark Ages; you look terrible in the light!" ,
                    "You started at the bottom… and it’s been downhill ever since." ,
                    "You have the perfect face for radio." ,
                    "You are as strong as an ox and almost as intelligent." ,
                    "Your gene pool could use a little chlorine." ,
                    "I love how you just don't care what you look like." ,
                    "You're kinda like Rapunzel except instead of letting down your hair you let down everyone in your life." ,
                    "You have more dick in your personality than you do in your pants." ,
                    "I'd say your aim is cancer but at least cancer kills." ,
                    "Are you so alone that you need to ask a bot for an insult to feel alive?" ,
                    "It's ok to be bad. Someone has to fill out the bell curve." ,
                    "People like talking to you at parties because the music drowns out your personality." ,
                    "You sound like you eat cigarettes." ,
                    "You look like you were drawn with my left hand." ,
                    "Maybe your mom should have done a better job raising you." ,
                    "If your eyes were any further apart, you'd be a herbivore." ,
                    "Your eyes are like stars. Not because they're pretty, but because they're so far apart." ,
                    "I know five fat people and you're three of them.",
                    "You suck dick for the taste." ,
                    "I envy everyone you have never met." ,
                    "You consistently set low expectations and fail to achieve them." ,
                    "Life is full of disappointments, just ask your parents." ,
                    "I would unplug your life support to charge my phone." ,
                    "You are like the sun... because it hurts to  look at you." ,
                    "They would accept your spit at a sperm bank.",
                    "I'd challenge you to a battle of wits, but I see you're unarmed.",
                    "Your thoughts are worth their weight in gold." ,
                    "You look like a before picture." ,
                    "Do you realize that people just tolerate you?" ,
                    "If you were any more inbred you'd be a sandwich." ,
                    "I treasure the time I don't spend with you." ,
                    "You look like you're going to spend your life having one epiphany after another, always thinking you've finally figured out what's holding you back, and how you can finally be productive and creative and turn your life around. But nothing will ever change. That cycle of mediocrity isn't due to some obstacle. It's who you are. The thing standing in the way of your dreams is that the person having them is you." ,
                    "Your mother was a hamster and your father smelt of elderberries; I fart in your general direction."
            };
         

            await ReplyAsync(freshinsult[rand.Next(freshinsult.Length)]);
        }
      
    }
}
