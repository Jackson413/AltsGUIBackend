using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AltsGUIBackend
{
    class Program
    {
        public static string path = @"accounts.txt";
        public static string consoleClientPath = "C:\\users\\Jackson\\Desktop\\ConsoleClient & MinecraftClient.exe ";
        static void Main(string[] args)
        {
            Accounts accounts = new Accounts();
            Messaging messaging = new Messaging();
            ProcessHandler processhandler = new ProcessHandler();
            accounts.FileCheck();
            messaging.WelcomeMessage();
            processhandler.WindowMath();
            Console.ReadLine();
        }
    }
}
