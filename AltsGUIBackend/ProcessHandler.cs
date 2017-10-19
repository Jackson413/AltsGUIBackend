using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace AltsGUIBackend
{
    class ProcessHandler
    {
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        public void WindowMath()
        {
            int accountsModulus2 = Accounts.accountTotalNumber % 2;
            int leftColumnAccounts;
            int rightColumnAccounts;
            if (accountsModulus2 == 1) //Number of accounts is odd
            {
                leftColumnAccounts = (Accounts.accountTotalNumber - 1) / 2;
                rightColumnAccounts = leftColumnAccounts + 1;
            }
            else
            {
                leftColumnAccounts = Accounts.accountTotalNumber / 2;
                rightColumnAccounts = Accounts.accountTotalNumber / 2;
            }
            //Console.WriteLine("Number of accounts on left column:  " + leftColumnAccounts);
            List<string> leftColumnAccountsList = new List<string>();
            for (int i = 0; i < leftColumnAccounts; i++)
            {
                //Console.WriteLine(Accounts.accountAll[i]);
                leftColumnAccountsList.Add(Accounts.accountAll[i]); //Adding window group for left side column
            }
            //Console.WriteLine("Number of accounts on right column: " + rightColumnAccounts);
            List<string> rightColumnAccountsList = new List<string>();
            for (int i = 0; i < rightColumnAccounts; i++)
            {
                //Console.WriteLine(Accounts.accountAll[i + (leftColumnAccounts)]);
                rightColumnAccountsList.Add(Accounts.accountAll[i + (leftColumnAccounts)]); //Adding window grouping for right side column
            }
            Process myProcess = new Process();//Actual Starting of Programs
            for (int i = 0; i < Accounts.accountAll.Length; i++)
            {
                int j = i + 1;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = "CMD.exe";
                //startInfo.Arguments = "/K title " + Accounts.accountAll[i] + "&timeout " + 5 * i + " > nul" + "& cd " + Program.consoleClientPath + j + "_" + Accounts.accountAll[i] + ".ini";
                startInfo.Arguments = "/K title " + Accounts.accountAll[i];

                process.StartInfo = startInfo;
                process.Start();
                Thread.Sleep(250);
                //The world's most messy code
                double heightCalcLeft = (HeightCalculation.WorkableHeight() / leftColumnAccounts);
                double leftRound = (double)Math.Ceiling(heightCalcLeft / 5) * 5;
                int leftRoundInt = Convert.ToInt32(leftRound);
                if (i < leftColumnAccounts) //Left Column
                {
                    ProcessHandler.MoveWindow(process.MainWindowHandle, Program.monitorTweak, i * HeightCalculation.WorkableHeight() / leftColumnAccounts, 669, leftRoundInt, true);
                }
                else //                     Right Column
                    ProcessHandler.MoveWindow(process.MainWindowHandle, Program.monitorTweak + 669, (i - leftColumnAccountsList.Count()) * HeightCalculation.WorkableHeight() / rightColumnAccounts, 669, HeightCalculation.WorkableHeight() / rightColumnAccounts, true);
            }
        }
    }
}
