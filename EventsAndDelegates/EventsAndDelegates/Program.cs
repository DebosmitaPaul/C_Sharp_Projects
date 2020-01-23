using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vedio vd = new Vedio() { tittle = "Vedio1" };
            VedioEncoder vdEncoder = new VedioEncoder(); // Publisher
            MailService mailSer = new MailService(); //Subscriber
            MessageService msgSer = new MessageService(); //Subscriber

            //Subscription
            // += means register the handler
            vdEncoder.VedioEncoded += mailSer.OnVedioEnCoded;
            //I m not using any [OnVedioEnCoded()] bracket here.. name of the method. [mailSer.OnVedioEnCoded;] means ref for a pointer to that method
            vdEncoder.VedioEncoded+= msgSer.OnMessageEncoded ;

            vdEncoder.Encode(vd);
        }
    }
}
