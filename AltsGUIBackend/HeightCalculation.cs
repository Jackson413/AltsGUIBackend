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

namespace AltsGUIBackend
{
    class HeightCalculation
    {
        public static int WorkableHeight()
        {
            //Get the handle of the task bar
            IntPtr TaskBarHandle;
            TaskBarHandle = FindWindow("Shell_traywnd", "");

            RECT rct;

            //Get the taskbar window rect in screen coordinates
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            GetWindowRect(TaskBarHandle, out rct);
            int workableHeight = screenHeight - (rct.Bottom - rct.Top);
            return workableHeight;
        }
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }
    }
}
