using Xamarin.Forms;
using Camera.ViewModels;

namespace Camera.Pages
{
    public partial class InicialPage : ContentPage
    {
        public InicialPage()
        {
            InitializeComponent();
            BindingContext = new InicialViewModel();
        }
    }
}
