using System;
using Discord.Net;
using Discord;
using System.Threading.Tasks;
using Discord.WebSocket;
using Discord.Commands;
using Discord.Audio;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.IO;

namespace OrangeBot
{
    class Program
    {
        static void Main(string[] args) => new Program().RunBotAsync().GetAwaiter().GetResult();
        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;

       
        public async Task RunBotAsync()
        {

            //Creating new client, command, and service
            _client = new DiscordSocketClient();
            _commands = new CommandService();

            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();


            //Bot token, used to login to bot client, this code is important dont change it/ share it
            string Bottoken = "";



            //Event Subscriptions

            _client.Log += Log;



            await RegisterCommandsAsync();

            //Login to bot async
            await _client.LoginAsync(TokenType.Bot, Bottoken);
            //Start the client async
            await _client.StartAsync();
            int a = 0;




            //Have bot cycle between "playing with my dad" and "!help"
            while (a == 0) {
                await Task.Delay(10000);
                await _client.SetGameAsync("with my dad");
                await Task.Delay(10000);
                await _client.SetGameAsync("!help");
            }

            //wait forever
            await Task.Delay(-1);
        }

        //Basic loging in cmd
        private Task Log(LogMessage arg)
        {
            Console.WriteLine(arg);

            return Task.CompletedTask;
        }

        //Registering Commands Astnc
        public async Task RegisterCommandsAsync()
        {
            _client.MessageReceived += HandCommandAsync;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly());


        }



        //Trigger
        private async Task HandCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            if (message is null || message.Author.IsBot) return;

            int argpos = 0;

            //Defining Trigger as !, mention to the bot, or ""; argpos = 0
            if(message.HasStringPrefix("!", ref argpos) || message.HasMentionPrefix(_client.CurrentUser, ref argpos) || message.HasStringPrefix("", ref argpos))
            {
                var context = new SocketCommandContext(_client, message);

                var result = await _commands.ExecuteAsync(context, argpos, _services);


                //Error loging
                if (!result.IsSuccess)
                {
                    Console.WriteLine(result.ErrorReason);
                }

            }
        }
    }
}
