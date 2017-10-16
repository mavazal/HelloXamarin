using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Practices.Unity;
using Prism.Unity;

namespace HelloXamarin.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(UXDivers.Gorilla.Droid.Player.CreateApplication(this,new UXDivers.Gorilla.Config("Good Gorilla")
                        .RegisterAssembliesFromTypes<Prism.IPlatformInitializer<AndroidInitializer>, Prism.PrismApplicationBase<App>, Prism.Unity.PrismApplication>()
                        //.RegisterAssemblyFromType<CircleControl>()
                        //.RegisterAssemblyFromType<BadgeControl>()
                        //.RegisterAssemblyFromType<AwesomeLabelControl>()
                        //.RegisterAssemblyFromType<CircleRenderer>()
                        //.RegisterAssemblyFromType<AwesomeLabelRenderer>()
                        //.RegisterAssemblyFromType<AnimationColumnDashboardBehavior>()
    ));
            //LoadApplication(new App());
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }
}