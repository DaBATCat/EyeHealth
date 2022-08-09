using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace EyeHealth
{
    internal class InternalTools
    {
        public static int SecondsInMiliseconds(int seconds) => seconds * 1000;
        public static int SecondsInMinutes(int minutes) => minutes * 60;

        public static void DefaultToastNotification(string msg)
        {
            new ToastContentBuilder().AddArgument("action", "viewConversation")
                      .AddArgument("conversationId", 9813)
                      .AddText(msg)
                      .Show();
        }        
        public static void DefaultToastNotification(string msg, string lowerText)
        {
            new ToastContentBuilder().AddArgument("action", "viewConversation")
                      .AddArgument("conversationId", 9813)
                      .AddText(msg)
                      .AddText(lowerText)
                      .Show();
            
        }
    }
}
