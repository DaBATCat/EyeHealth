using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace EyeHealth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A notification delay with 20 minutes
            Reminder reminder = new Reminder(1);
            reminder.RemindOnCloseEyes();
            Console.ReadKey();
        }
    }
}
