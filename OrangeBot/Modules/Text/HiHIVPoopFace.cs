using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class HiHIVPoopFace : ModuleBase<SocketCommandContext>
{


    [Command("Hello everyone.")] // First word of command
    public async Task hi()
    {   //If martti says Hello everyone, respond with Hello HIVpoopface
        if (Context.User.Username == "HIVpoopface")
            await ReplyAsync($"Hello {Context.User.Username}.");


        //Do nothing
    }
}