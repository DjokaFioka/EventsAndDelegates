using System;

namespace EventsAndDelegates
{
    public class MessageService : IAudioEncoderListener
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
        
        //Java way
        public void OnAudioEncoded(Audio audio)
        {
            Console.WriteLine("MessageService: Sending text message after encoding video... " + audio.Title);
        }
    }
}
