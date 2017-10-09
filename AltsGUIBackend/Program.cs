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
        static void Main(string[] args)
        {
            string path = @"accounts.txt";
            string accountInput = "0";
            string[] accountLines = { };
            string[] accountPrimary = { };
            string[] accountSecondary = { };
            //This is a test.
            if (File.Exists(path))
            {
                accountInput = File.ReadAllText(path);
                accountLines = accountInput.Split('\n');
            }
            else
            {
                Console.WriteLine("Error! accounts.txt was not found! Ensure the file is in the same directory and try again!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            accountPrimary = accountLines[0].Split(' '); //Forming Primary
            accountSecondary = accountLines[1].Split(' '); //Forming Secondary
            string[] accountAll = new string[accountPrimary.Length + accountSecondary.Length]; //Declaring All
            Array.Copy(accountPrimary, accountAll, accountPrimary.Length); //Copying All
            Array.Copy(accountSecondary, 0, accountAll, accountPrimary.Length, accountSecondary.Length); //Formation of All
            Console.WriteLine("\t\t\t413 AltsGUI Initialization\n");
            Console.WriteLine("{0} Total Accounts in accounts.txt:\n", accountAll.Count());
            for (int i = 0; i < accountAll.Length; i++)
            {
                Console.WriteLine(accountAll[i]);
            }
            Console.WriteLine("\nGroup One Accounts:");
            for (int i = 0; i < accountPrimary.Length; i++)
            {
                Console.Write("\t" + accountPrimary[i]);
            }
            Console.WriteLine("\n\nGroup Two Accounts:");
            for (int i = 0; i < accountSecondary.Length; i++)
            {
                Console.Write("\t" + accountSecondary[i]);
            }
            Console.WriteLine("\n\n\t\t\tPress <Enter> to Begin");
            Console.ReadLine();
            Process myProcess = new Process();
            for(int i = 0; i < 1; i++)
            {
                myProcess.StartInfo.FileName = "C:\\windows\\system32\\cmd.exe";
                myProcess.Start();
            }
        }
        private static void GetAccounts()
        {

        }
    }
}
