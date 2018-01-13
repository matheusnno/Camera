using System.IO;
using AVFoundation;
using Foundation;
using UIKit;
using System.Threading.Tasks;

namespace Camera.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            UIApplication.SharedApplication.IdleTimerDisabled = true;

            return base.FinishedLaunching(app, options);
        }
    }
}
