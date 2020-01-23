using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnMessageEncoded(object source, VedioEventArgs args)
        {
            Console.WriteLine("Message service sent an text message....");
        }
    }
}
