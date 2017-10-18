using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;

namespace AltsGUIBackend
{
    class ProcessHandler
    {
        public void OpenWindows()
        {
            Process myProcess = new Process();
            for (int i = 0; i < Accounts.accountAll.Length; i++)
            {
                int j = i + 1;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = "CMD.exe";
                startInfo.Arguments = "/K cd C:\\users\\Jackson\\Desktop\\ConsoleClient & MinecraftClient.exe " + j + "_" + Accounts.accountAll[i] + ".ini";
                Console.WriteLine("/K C:\\users\\Jackson\\Desktop\\ConsoleClient\\MinecraftClient.exe " + j + "_" + Accounts.accountAll[i] + ".ini");
                process.StartInfo = startInfo;
                process.Start();
            }
        }
    }
}
