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
        public static int monitorTweak = -3840;
        static void Main(string[] args)
        {
            ErrorHandling errorhandling = new ErrorHandling();
            errorhandling.FileCheck();
            Accounts accounts = new Accounts();
            accounts.GetAccounts();
            Messaging messaging = new Messaging();
            ProcessHandler processhandler = new ProcessHandler();
            messaging.WelcomeMessage();
            processhandler.WindowMath();
            Console.ReadLine();
            Console.Clear();
            string altInput;
            while (true)
            {
                Console.Write("AltCMD: ");
                altInput = Console.ReadLine();
                Console.WriteLine(altInput);
                if (altInput == "exit")
                    break;
            }
        }
    }
}
