using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        //Event Handler
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MessageService: Sending text message after encoding video...");
        }
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending text message after encoding video... " + args.Video.Title);
        }
    }
}
