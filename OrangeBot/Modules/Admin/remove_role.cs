using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    [Group("remove_role")]  // First word of command
    public class remove_role : ModuleBase<SocketCommandContext>
    {
        [Command("sub")]  // Second word of command
        public async Task sub()
        {
            //set role = to "Sub"
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "Sub");

            //Make sure user is in the role-assignment channel
            if (Context.Channel.Name == "role-assignment")
            {
                //Remove role from user
                await (Context.User as IGuildUser).RemoveRoleAsync(role);
                await ReplyAsync($"The role Sub was removed from {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }

        [Command("NSFW")]  // Second word of command
        public async Task forbiden()
        {
            //set var role = "NSFW"
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "NSFW");

            //Make sure user is in the channel role-assignment
            if (Context.Channel.Name == "role-assignment")
            {
                //Remove role from user
                await (Context.User as IGuildUser).RemoveRoleAsync(role);
                await ReplyAsync($"The role NSFW was removed from {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }
        [Command("friends")]  // Second word of command
        public async Task friends()
        {
            //Set var role = "friends"
            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "friends");

            //Make sure user is in channel role-assignment
            if (Context.Channel.Name == "role-assignment")
            {
                //Remove role from user
                await (Context.User as IGuildUser).RemoveRoleAsync(role);
                await ReplyAsync($"The role friends was removed from {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }
    }
}
