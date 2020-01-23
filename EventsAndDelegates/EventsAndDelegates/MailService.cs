using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVedioEnCoded(object source, VedioEventArgs args)
        {
            Console.WriteLine("Mail service sending an email.....");
        }
    }
}
