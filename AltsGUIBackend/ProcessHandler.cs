using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace AltsGUIBackend
{
    class ProcessHandler
    {
        public void OpenWindows()
        {
            Process myProcess = new Process();
            for (int i = 0; i < 1; i++)
            {
                myProcess.StartInfo.FileName = "C:\\windows\\system32\\cmd.exe";
                myProcess.Start();
            }
        }
}
}
