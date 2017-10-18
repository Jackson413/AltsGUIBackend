using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AltsGUIBackend
{
    class Accounts
    {
        public int accountInput { get; private set; }
        public string[] accountLines { get; private set; }
        public string[] accountPrimary { get; private set; }
        public string[] accountSecondary { get; private set; }
        public string[] accountAll { get; private set; }
        public string path = Program.path;
        public void FileCheck() //Here is the method for checking if the accounts file exists. If it does not, the program will display an error and exit.
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Error! File \"accounts.txt\" was not found! Ensure the file is in the same directory and try again!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public void GetAccounts()
        {
            string accountInput = "0";
            accountInput = File.ReadAllText(path);
            accountLines = accountInput.Split('\n');
            accountPrimary = accountLines[0].Split(' '); //Forming Primary
            accountSecondary = accountLines[1].Split(' '); //Forming Secondary
            accountAll = new string[accountPrimary.Length + accountSecondary.Length]; //Declaring All
            Array.Copy(accountPrimary, accountAll, accountPrimary.Length); //Copying All
            Array.Copy(accountSecondary, 0, accountAll, accountPrimary.Length, accountSecondary.Length); //Formation of All
        }
    }
}
