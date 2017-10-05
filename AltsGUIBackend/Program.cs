using System;
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
            if (File.Exists(path))
            {
                accountInput = File.ReadAllText(path);
                accountLines = accountInput.Split('\n');
            }
            else
            {
                Console.WriteLine("Error! File was not found! Try again and relaunch application!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            for (int i = 0; i < accountLines.Length; i++)
            {
                Console.WriteLine(accountLines[i]);
            }
            Console.ReadLine();

        }
    }
}
