using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video()
            {
                Title = "Video 1"
            };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subsriber
            var messageService = new MessageService(); //another subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //reference - pointer to a method. It's wrong to write it like this mailService.OnVideoEncoded();
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; 

            videoEncoder.EncodeVideo(video);

            //Java way with interface callback - can handle only one at a time
            var audio = new Audio()
            {
                Title = "Audio 101"
            };
            
            IAudioEncoderListener mailListener = new MailService();

            var audioEncoder = new AudioEncoder(mailListener);
            audioEncoder.EncodeAudio(audio);
        }
    }
}
