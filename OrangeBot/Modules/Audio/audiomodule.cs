/*using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeSearch;
using Discord.Audio;
using System.Collections.Concurrent;

namespace ConsoleApp1.Modules
{
   


    public class audiomodule : ModuleBase<SocketCommandContext>
    {
        private readonly ConcurrentDictionary<ulong, IAudioClient> ConnectedChannels = new ConcurrentDictionary<ulong, IAudioClient>();

        [Command("join")] 
        public async Task join()
        {
            await JoinAudio(Context.Guild, (Context.User as IVoiceState).VoiceChannel);
        }

        [Command("leave"), Alias("Disconnect")]
        public async Task Leave()
        {
            await LeaveAudio(Context.Guild);
        }

        [Command("play")]
        public async Task play([Remainder] string search)
        {
            IAudioClient client;
            IVoiceChannel target = (Context.User as IVoiceState).VoiceChannel);

            if (ConnectedChannels.TryGetValue(Context.Guild.Id, out client))
            {
                return;
            }
            if (target.Guild.Id != Context.Guild.Id)
            {
                return;
            }

            var audioClient = await target.ConnectAsync();

            ConnectedChannels.TryAdd(Context.Guild.Id, audioClient);
           
            VideoSearch list = new VideoSearch();

            var item = list.SearchQuery(search, 1);

            await ReplyAsync($"🔎 Searching for: `{search}`");
            await ReplyAsync($"🎶 Now playing `{item[1].Title}`");

            }
        }



        public async Task JoinAudio(IGuild guild, IVoiceChannel target)
        {
            IAudioClient client;
            if (ConnectedChannels.TryGetValue(guild.Id, out client))
            {
                return;
            }
            if (target.Guild.Id != guild.Id)
            {
                return;
            }

            var audioClient = await target.ConnectAsync();

            ConnectedChannels.TryAdd(guild.Id, audioClient);
            return;
        }

        public async Task LeaveAudio(IGuild guild)
        {
            IAudioClient client;
            if (ConnectedChannels.TryRemove(guild.Id, out client))
            {
                await client.StopAsync();
            }
        }
    }

*/