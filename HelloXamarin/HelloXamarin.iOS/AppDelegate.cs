
using Foundation;
using Microsoft.Practices.Unity;
using Prism;
using Prism.Unity;
using UIKit;

namespace HelloXamarin.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
            //LoadApplication(new App());

            LoadApplication(UXDivers.Gorilla.iOS.Player.CreateApplication(new UXDivers.Gorilla.Config("Good Gorilla")
                        .RegisterAssembliesFromTypes<Prism.IActiveAware, Prism.PrismApplicationBase<App>, Prism.Unity.PrismApplication>()
                        //.RegisterAssemblyFromType<CircleControl>()
                        //.RegisterAssemblyFromType<CircleRenderer>()
                        //.RegisterAssemblyFromType<BadgeControl>()
    ));

            return base.FinishedLaunching(app, options);
		}
	}

    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }
}
