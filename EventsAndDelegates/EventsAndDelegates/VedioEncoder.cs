using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class VedioEventArgs : EventArgs
    {
        public Vedio vedio{ get; set; }
    }
    public class VedioEncoder
    {
        /// <summary>
        /// Wangt to Implement an Event in VedioEncoder such that when Encodeing is finished it will notify the interseted in this event  , that anyone can interset
        /// </summary>
        /// <param name="vedio"></param>
        // 1. define delegate.  An aggrement b/w publisher and subscriber
        // 2.define Event based on delegate
        // 3. raise or publish the event

        //public delegate void VedioEncodedEventHander(object ob, EventArgs args);
        public delegate void VedioEncodedEventHander(object ob, VedioEventArgs args);
        public event VedioEncodedEventHander VedioEncoded;

        //public event EventHandler<VedioEventArgs> VedioEncoded;
        public void Encode(Vedio vedio)  //eventhandler for the subscriber
        {
            Console.WriteLine($"Encoding Vedio....{vedio.tittle}");
            Thread.Sleep(3000);
            OnvedioEncoded(vedio);
        }

        // 3.raise or publish the event .... for that we need to create an method
        private void OnvedioEncoded(Vedio vedio)
        {
             if(VedioEncoded!=null)
                //VedioEncoded(this, EventArgs.Empty);
                VedioEncoded(this, new VedioEventArgs() { vedio = vedio});

                Console.WriteLine("In OnvedioEncoded....");
        }
    }
}
