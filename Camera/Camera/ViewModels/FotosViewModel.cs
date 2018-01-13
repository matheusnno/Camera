using Xamarin.Forms;
using Camera.Services;

namespace Camera.ViewModels
{
    public class FotosViewModel : BaseViewModel
    {
        Command changeAnimationCommand { get; }

        private ImageSource _imgSource;
        public ImageSource ImgSource
        {
            get { return _imgSource; }
            set { SetProperty(ref _imgSource, value); }
        }

        public FotosViewModel()
        {
            //ImgSource = ImageSource.FromResource("img1.jpg");
            //DependencyService.Get<IPlayAudio>()?.PlayAudio("Music.mp3");
            changeAnimationCommand = new Command(ExecuteChangeAnimationCommand);
        }

        void ExecuteChangeAnimationCommand(object obj)
        {

        }
    }
}
