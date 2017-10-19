using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AltsGUIBackend
{
    class ErrorHandling
    {
        public void FileCheck() //Here is the method for checking if the accounts file exists. If it does not, the program will display an error and exit.
        {
            if (!File.Exists(Program.path))
            {
                Console.WriteLine("Error! File \"accounts.txt\" was not found!\n\nEnsure the file is in the same directory and try again!\n\nPress <Enter> to exit the program.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
