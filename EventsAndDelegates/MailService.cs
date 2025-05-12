using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        //Event Handler
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending email after video was encoded...");
        }
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending email after video was encoded... " + args.Video.Title);
        }
    }
}
