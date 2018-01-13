using Xamarin.Forms;

namespace Camera.ViewModels
{
    public class InicialViewModel : BaseViewModel
    {
        public Command IniciaCommand { get; }

        public InicialViewModel()
        {
            IniciaCommand = new Command(ExecuteIniciaCommand);
        }

        async void ExecuteIniciaCommand()
        {
            await PushAsync<FotosViewModel>();
        }
    }
}
