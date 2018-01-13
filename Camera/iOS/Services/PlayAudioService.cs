using AVFoundation;
using Camera.iOS.Services;
using Foundation;
using Xamarin.Forms;
using Camera.Services;

[assembly: Dependency(typeof(PlayAudioService))]
namespace Camera.iOS.Services
{
    public class PlayAudioService : IPlayAudio
    {
        private AVAudioPlayer backgroundMusic;
        public void PlayAudio(string filename)
        {
            var session = AVAudioSession.SharedInstance();
            session.SetCategory(AVAudioSessionCategory.Playback, AVAudioSessionCategoryOptions.DuckOthers);
            session.SetActive(true);

            NSUrl songURL;

            // Any existing background music?
            if (backgroundMusic != null)
            {
                //Stop and dispose of any background music
                backgroundMusic.Stop();
                backgroundMusic.Dispose();
            }

            // Initialize background music
            songURL = new NSUrl(filename);
            NSError err;
            backgroundMusic = new AVAudioPlayer(songURL, "mp3", out err);
            backgroundMusic.Volume = 0.5f;
            backgroundMusic.FinishedPlaying += delegate
            {
                backgroundMusic = null;
            };
            backgroundMusic.NumberOfLoops = -1;
            backgroundMusic.Play();
        }
    }
}
