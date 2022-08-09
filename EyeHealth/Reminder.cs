using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Windows;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace EyeHealth
{
    internal class Reminder
    {
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private int timeWindow;
        private IntPtr h;
        public bool IsRunning { get; set; }
        public Reminder(int timeWindowMinutes) 
        { 
            this.timeWindow = timeWindowMinutes;

            //This hides the Task in the background
            h = Process.GetCurrentProcess().MainWindowHandle;
            ShowWindow(h, 0);
            //-----

        }

        public void RemindOnCloseEyes()
        {
            IsRunning = true;
            while (IsRunning)
            {
                Task.Delay(InternalTools.SecondsInMinutes(InternalTools.SecondsInMiliseconds(timeWindow))).Wait();
                InternalTools.DefaultToastNotification("20 Minutes up!", "Close the eyes for 30 seconds.");
                Task.Delay(InternalTools.SecondsInMiliseconds(30)).Wait();
                InternalTools.DefaultToastNotification("30 seconds up!", "You can open your eyes now.");
            }
        }
    }
}
