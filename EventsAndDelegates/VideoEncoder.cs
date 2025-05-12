using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1 - Define a delegate
        //public delegate void VideoEncodedEventHandler(object source, EventArgs agrs);
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs agrs); //instead of this delegate and custom handler we can use EventHandler or EventHandler<TEventArgs>
        
        // 2 - Define an event based on that delegate
        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public event EventHandler VideoEncoding; //no parameters to pass

        public void EncodeVideo(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(2000);

            // 3 - Raise that event
            //OnVideoEncoded(); //before when we were using EventArgs instead of VideoEventArgs
            OnVideoEncoded(video);
        }

        //protected virtual void OnVideoEncoded()
        //{
        //    if (VideoEncoded != null)
        //    {
        //        VideoEncoded(this, EventArgs.Empty);
        //    }
        //}

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
