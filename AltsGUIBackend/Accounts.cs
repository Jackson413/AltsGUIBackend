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
        public static string accountInput = File.ReadAllText(Program.path);
        public static string[] accountLines = accountInput.Split('\n');
        public static string[] accountPrimary = accountLines[0].Split(' '); //Forming Primary
        public static string[] accountSecondary = accountLines[1].Split(' '); //Forming Secondary
        public static string[] accountAll = new string[accountPrimary.Length + accountSecondary.Length]; //Declaring All
        public void FileCheck() //Here is the method for checking if the accounts file exists. If it does not, the program will display an error and exit.
        {
            if (!File.Exists(Program.path))
            {
                Console.WriteLine("Error! File \"accounts.txt\" was not found! Ensure the file is in the same directory and try again!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
                GetAccounts();
        }
        public void GetAccounts() //After refactoring, I redid the other stuff into more accessible variables. I need to run this in order to build accountsAll
        {
            Array.Copy(accountPrimary, accountAll, accountPrimary.Length); //Copying All
            Array.Copy(accountSecondary, 0, accountAll, accountPrimary.Length, accountSecondary.Length); //Formation of All
        }
    }
}
