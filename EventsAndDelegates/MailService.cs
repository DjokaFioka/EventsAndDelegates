using System;

namespace EventsAndDelegates
{
    public class MailService : IAudioEncoderListener
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

        //Java way
        public void OnAudioEncoded(Audio audio)
        {
            Console.WriteLine("MailService: Sending email after audio was encoded... " + audio.Title);
        }
    }
}
