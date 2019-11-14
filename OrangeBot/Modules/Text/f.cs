using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class f : ModuleBase<SocketCommandContext>
{
    

    [Command("f")] //First word of command
    public async Task theletterf()
    {
        int count;

        // Test if existing fcount
        if (!File.Exists("fcount.txt"))
        {
            // Initialize counter to zero if non-existant
            count = 0;
            // Create fcount file
            File.Create("fcount.txt");
        }
        else
        {
            // Initialize counter to last written value if existant
            count = int.Parse((await File.ReadAllTextAsync("fcount.txt")).Trim());
        }

        //Incriment count
        count++;

        //Convert count to string type
        string stringcount = count.ToString();

        // Write new count to file
        await File.WriteAllTextAsync("fcount.txt", stringcount);

    }
}