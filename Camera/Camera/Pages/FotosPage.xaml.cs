using Xamarin.Forms;
using System.Threading.Tasks;
using System;
using Camera.ViewModels;
using Camera.Services;
using Xamarin.Forms.Xaml;
using Xamanimation;

namespace Camera.Pages
{
    public partial class FotosPage : ContentPage
    {
        public FotosPage()
        {
            InitializeComponent();
            BindingContext = new FotosViewModel();
            int i = 1;

            texto.Text = "Olá! Parece que não abriu";
            texto2.Text = "o aplicativo que você queria";

            inicia.Clicked += async (sender, e) =>
            {
                await Task.Delay(500);
                DependencyService.Get<IPlayAudio>()?.PlayAudio("Music.mp3");
                inicia.Text = "";
                inicia.IsEnabled = false;
                texto2.Text = "";
                texto.Text = "Depois tiramos a foto que você queria!";
                await Task.Delay(3000);
                texto.Text = "Agora se prepare para a maior surpresa da sua vida !";
                await Task.Delay(3000);
                texto.Text = "";

                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;

                await Task.Delay(3000);
                await image.FadeTo(0, 2000);
                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await image.FadeTo(1, 2000);
                await Task.Delay(3000);
                await image.TranslateTo(600, 0, 1500);
                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await image.TranslateTo(0, 0, 1500);
                await Task.Delay(3000);

                await Task.WhenAll
                (
                    image.RotateTo(360, 2000),
                    image.ScaleTo(0, 2000)
                );
                image.Rotation = 0;

                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await Task.WhenAll
                (
                    image.RotateTo(-360, 2000),
                    image.ScaleTo(1, 2000)
                );
                image.Rotation = 0;
                await Task.Delay(3000);

                await image.TranslateTo(0, Height - image.Width / 2 - image.Height, 2000, CustomEasing());
                await Task.Delay(1000);
                await image.TranslateTo(0, 600, 500);

                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await Task.Delay(500);
                await image.TranslateTo(0, 0, 2000, CustomEasing());

                await Task.Delay(3000);
                await Task.WhenAny<bool>(
                    image.RotateTo(720, 3000, Easing.SpringOut),
                    image.FadeTo(0, 3000),
                    image.ScaleTo(2, 3000)
                );

                image.Rotation = 0;

                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await Task.WhenAll
                (
                    image.RotateTo(720, 3000, Easing.SpringIn),
                    image.FadeTo(1, 3000),
                    image.ScaleTo(1, 3000)
                );
                await Task.Delay(3000);
                await image.ScaleTo(0, 2000, Easing.BounceIn);

                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await image.ScaleTo(1, 2000, Easing.BounceIn);

                await Task.Delay(3000);
                await image.FadeTo(0, 2000);
                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await image.FadeTo(1, 2000);
                await Task.Delay(3000);
                await image.TranslateTo(600, 0, 1500);
                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await image.TranslateTo(0, 0, 1500);
                await Task.Delay(3000);

                await Task.WhenAll
                (
                    image.RotateTo(360, 2000),
                    image.ScaleTo(0, 2000)
                );
                image.Rotation = 0;

                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await Task.WhenAll
                (
                    image.RotateTo(-360, 2000),
                    image.ScaleTo(1, 2000)
                );
                image.Rotation = 0;
                await Task.Delay(3000);
                await image.TranslateTo(0, Height - image.Width / 2 - image.Height, 2000, CustomEasing());
                await image.TranslateTo(0, 600, 500);

                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await Task.Delay(500);
                await image.TranslateTo(0, 0, 2000, CustomEasing());

                await Task.Delay(3000);
                await Task.WhenAny<bool>(
                    image.RotateTo(720, 3000, Easing.SpringOut),
                    image.FadeTo(0, 3000),
                    image.ScaleTo(2, 3000)
                );

                image.Rotation = 0;

                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await Task.WhenAll
                (
                    image.RotateTo(720, 3000, Easing.SpringIn),
                    image.FadeTo(1, 3000),
                    image.ScaleTo(1, 3000)
                );
                await Task.Delay(3000);
                await image.ScaleTo(0, 2000, Easing.BounceIn);

                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await image.ScaleTo(1, 2000, Easing.BounceIn);

                await Task.Delay(3000);
                await image.FadeTo(0, 2000);
                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await image.FadeTo(1, 2000);
                await Task.Delay(3000);
                await image.TranslateTo(600, 0, 1500);
                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await image.TranslateTo(0, 0, 1500);
                await Task.Delay(3000);

                await Task.WhenAll
                (
                    image.RotateTo(360, 2000),
                    image.ScaleTo(0, 2000)
                );
                image.Rotation = 0;

                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await Task.WhenAll
                (
                    image.RotateTo(-360, 2000),
                    image.ScaleTo(1, 2000)
                );
                image.Rotation = 0;
                await Task.Delay(3000);
                await image.TranslateTo(0, Height - image.Width / 2 - image.Height, 2000, CustomEasing());
                await image.TranslateTo(0, 600, 500);

                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await Task.Delay(500);
                await image.TranslateTo(0, 0, 2000, CustomEasing());

                await Task.Delay(3000);
                await Task.WhenAny<bool>(
                    image.RotateTo(720, 3000, Easing.SpringOut),
                    image.FadeTo(0, 3000),
                    image.ScaleTo(2, 3000)
                );

                image.Rotation = 0;

                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await Task.WhenAll
                (
                    image.RotateTo(720, 3000, Easing.SpringIn),
                    image.FadeTo(1, 3000),
                    image.ScaleTo(1, 3000)
                );
                await Task.Delay(3000);
                await image.ScaleTo(0, 2000, Easing.BounceIn);

                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await image.ScaleTo(1, 2000, Easing.BounceIn);

                await Task.Delay(3000);
                await image.FadeTo(0, 2000);
                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await image.FadeTo(1, 2000);
                await Task.Delay(3000);
                await image.TranslateTo(600, 0, 1500);
                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await image.TranslateTo(0, 0, 1500);
                await Task.Delay(3000);

                await Task.WhenAll
                (
                    image.RotateTo(360, 2000),
                    image.ScaleTo(0, 2000)
                );
                image.Rotation = 0;

                await Task.Delay(500);
                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await Task.WhenAll
                (
                    image.RotateTo(-360, 2000),
                    image.ScaleTo(1, 2000)
                );
                image.Rotation = 0;
                await Task.Delay(3000);
                await image.TranslateTo(0, Height - image.Width / 2 - image.Height, 2000, CustomEasing());
                await image.TranslateTo(0, 600, 500);

                image.Source = ImageSource.FromResource($"Camera.Resources.img{i}.jpg");
                i++;
                await Task.Delay(500);
                await image.TranslateTo(0, 0, 2000, CustomEasing());

                while (true)
                {
                    await image.Animate(new HeartAnimation());
                    await Task.Delay(1500);
                    await image.ScaleTo(1, 100);
                }

            };
        }

        private Easing CustomEasing()
        => new Easing(t => Math.Abs(1 - Math.Cos(10 * Math.PI * t) * Math.Exp(-5 * t)));
    }
}
