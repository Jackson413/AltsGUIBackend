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
        static void Main(string[] args)
        {
            Accounts accounts = new Accounts();
            Messaging messaging = new Messaging();
            accounts.FileCheck();
            messaging.WelcomeMessage();
            Process myProcess = new Process();
            for(int i = 0; i < 1; i++)
            {
                myProcess.StartInfo.FileName = "C:\\windows\\system32\\cmd.exe";
                myProcess.Start();
            }
            Console.ReadLine();
        }
    }
}
