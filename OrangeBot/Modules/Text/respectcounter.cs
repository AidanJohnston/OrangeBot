using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class respectcounter : ModuleBase<SocketCommandContext>
{
    

    [Command("respectcounter")] // First word of command
    public async Task theletter()
    {
        int count = 0; // set count to zero

        //Open fcount.txt
        using (TextReader reader = File.OpenText("fcount.txt"))
        {
            //Set count to contence of file, convert to type int
            count = int.Parse(reader.ReadLine());
        }
        //Print amount of respects given
        await ReplyAsync($"{count} respects have been paid");

       

    }
}