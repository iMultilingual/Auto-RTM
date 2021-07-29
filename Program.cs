using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Auto_RTM
{
    class Program
    {

        static void Main(string[] args)
        {
            WebClient webpanda = new WebClient();
            string OwO = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Roblox\\Versions\\version-8181e7a1039c4c81";
            System.Console.Write("Panda Auto-RTM ( Auto-Roblox Time Machine )\n", System.Console.ForegroundColor = ConsoleColor.Blue);
            System.Console.Write("Join to Our Discord: https://discord.gg/4qk9at2D2g because it's a real state\n", System.Console.ForegroundColor = ConsoleColor.Blue);
            System.Console.Write("[ ---------------------------------------------------- ] \n", System.Console.ForegroundColor = ConsoleColor.White);

            System.Console.Write("Warning: This is only Work within 7-29-2021 or within the version of Roblox ( version-8181e7a1039c4c81 ). Any Future Update will cause this app no longer working.\n", System.Console.ForegroundColor = ConsoleColor.Yellow);
            System.Console.Write("If an Bug Occurred, Please Let us Know in the Discord. Thank you. also this App's Source can be found on https://github.com/iMultilingual/Auto-RTM. \n", System.Console.ForegroundColor = ConsoleColor.Yellow);
            // ----------- Finding Roblox Directory and its Version ----------- //
            System.Console.Write("[ Client ] - Finding Existing Roblox Files\n", System.Console.ForegroundColor = ConsoleColor.White);
            if (!Directory.Exists(OwO))
            {
                System.Console.Write("[ Client ] - Folder not founded or this Software are only designed for version-8181e7a1039c4c81\n", System.Console.ForegroundColor = ConsoleColor.White);
                Console.ReadKey();
                Environment.Exit(0);
                return;
            }

            // ----------- Deleting Roblox Player Beta ----------- //
            System.Console.Write("[ Client ] - Deleting Old Roblox Player (1/2),\n", System.Console.ForegroundColor = ConsoleColor.White);
            if (File.Exists(OwO + "\\RobloxPlayerBeta.exe"))
            {
                File.Delete(OwO + "\\RobloxPlayerBeta.exe");
            }
            if (File.Exists(OwO + "\\RobloxPlayerLauncher.exe"))
            {
                File.Delete(OwO + "\\RobloxPlayerLauncher.exe");
            }

            // ----------- Downloading RTM File ----------- //
            System.Console.Write("[ Client ] - Downloading & Applying RTM Files (1/2),\n", System.Console.ForegroundColor = ConsoleColor.White);
            webpanda.DownloadFile("https://cdn.discordapp.com/attachments/852719623270563863/870167031360651264/RobloxPlayerBeta.exe", OwO + "\\RobloxPlayerBeta.exe");
            
            System.Console.Write("[ Client ] - Downloading & Applying RTM Files (2z`/2),\n", System.Console.ForegroundColor = ConsoleColor.White);
            webpanda.DownloadFile("https://raw.githubusercontent.com/iMultilingual/Auto-RTM/main/RobloxPlayerLauncher.exe", OwO + "\\RobloxPlayerLauncher.exe");
            
            // ----------- Success  ----------- //
            System.Console.Write("[ Client ] - Congratulation! You can now use Any Exploit for now :D\n", System.Console.ForegroundColor = ConsoleColor.Green);
            Console.ReadKey();

        }
    }
}
