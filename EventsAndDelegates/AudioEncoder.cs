using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class AudioEncoder
    {
        private readonly IAudioEncoderListener _listener;

        public AudioEncoder(IAudioEncoderListener listener)
        {
            _listener = listener;
        }

        public void EncodeAudio(Audio audio)
        {
            Console.WriteLine("Audio is being encoded");
            Thread.Sleep(2000);

            if (_listener != null)
            {
                _listener.OnAudioEncoded(audio);
            }

        }
    }
}
