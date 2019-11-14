using Discord;
using Discord.Commands;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class leaderboard : ModuleBase<SocketCommandContext>
    {
        [Command("leaderboard")]
        public async Task leader()
        {
            string path = "C:\\Users\\Aidan Johnsotn\\Desktop\\coins\\";

            //Get array of all file in folder
           var files = Directory.GetFiles($"{path}", "*.txt");


            //Set up sorted list, key = content of file, value = adress of file

            SortedList <int, string> list = new SortedList<int, string>();
            for (int i = 0; i < files.Length; i++)
            {
                list.Add(int.Parse(File.ReadAllText(files[i])), files[i]);
            }
           
            //Set up Embed text
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("Gobal Leaderboard")
                   .WithDescription($"🥇 {list.Keys[files.Length - 1]} - {Path.GetFileNameWithoutExtension(list.Values[files.Length - 1])} \n" +         //First
                                    $"🥈 {list.Keys[files.Length - 2]} - {Path.GetFileNameWithoutExtension(list.Values[files.Length - 2])} \n" +         //Second  
                                    $"🥉 {list.Keys[files.Length - 3]} - {Path.GetFileNameWithoutExtension(list.Values[files.Length - 3])} \n" +         //Third
                                    $"👌 {list.Keys[files.Length - 4]} - {Path.GetFileNameWithoutExtension(list.Values[files.Length - 4])} \n" +         //Forth
                                    $"👌 {list.Keys[files.Length - 5]} - {Path.GetFileNameWithoutExtension(list.Values[files.Length - 5])} \n" +         //Fifth
                                    $"👌 {list.Keys[files.Length - 6]} - {Path.GetFileNameWithoutExtension(list.Values[files.Length - 6])}")       //Sixth
                   .WithColor(Color.Orange);
            await ReplyAsync("", false, builder.Build());
           

        }
    }
}



