using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltsGUIBackend
{
    class Messaging
    {
        public void WelcomeMessage()
        {
            Accounts acc = new Accounts();
            acc.GetAccounts();
            string[] accountPrimary = acc.accountPrimary;
            string[] accountSecondary = acc.accountSecondary;
            string[] accountAll = acc.accountAll;
            Console.WriteLine("\t\t\t413 AltsGUI Initialization\n");
            Console.WriteLine("{0} Total Accounts in {1}:\n", accountAll.Count(), Program.path);
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
        }
    }
}
