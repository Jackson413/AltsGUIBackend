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
            Console.WriteLine("\t\t\t413 AltsGUI Initialization\n");
            Console.WriteLine("{0} Total Accounts in {1}:\n", Accounts.accountAll.Count(), Program.path);
            for (int i = 0; i < Accounts.accountAll.Length; i++)
            {
                Console.WriteLine(Accounts.accountAll[i]);
            }
            Console.WriteLine("\nGroup One Accounts:");
            for (int i = 0; i < Accounts.accountPrimary.Length; i++)
            {
                Console.Write("\t" + Accounts.accountPrimary[i]);
            }
            Console.WriteLine("\n\nGroup Two Accounts:");
            for (int i = 0; i < Accounts.accountSecondary.Length; i++)
            {
                Console.Write("\t" + Accounts.accountSecondary[i]);
            }
            Console.WriteLine("\n\n\t\t\tPress <Enter> to Begin");
        }
    }
}
