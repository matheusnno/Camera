using Xamarin.Forms;
using Camera.Pages;
using Camera.Services;

namespace Camera
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FotosPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
