using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    [Group("add_role")] // First word of command
    public class add_role : ModuleBase<SocketCommandContext>
    {
        [Command("sub")] // Second word of command
        public async Task sub()
        {
            // set var role = "Sub"
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "sub");

            //Make sure user is in the channel role-assignment
            if (Context.Channel.Name == "role-assignment")
            {
                //Set user role to sub
                await (Context.User as IGuildUser).AddRoleAsync(role);
                await ReplyAsync($"The role sub was given to {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }

        [Command("NSFW")] //Second word of command
        public async Task forbiden()
        {
            // set var role = "NSFW"
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "NSFW");

            //Make sure user is in the channel role-assignment
            if (Context.Channel.Name == "role-assignment")
            {
                //Set user role to NSFW
                await (Context.User as IGuildUser).AddRoleAsync(role);
                await ReplyAsync($"The role NSFW was given to {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }
        [Command("friends")] // Second word of command
        public async Task friends()
        {
            //Set var role = "Friends"
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "Friends");

            //Make sure user is in the channel role-assignment
            if (Context.Channel.Name == "role-assignment")
            {
                //Set user role to Friends
                await (Context.User as IGuildUser).AddRoleAsync(role);
                await ReplyAsync($"The role friends was given to {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }
    }
}
