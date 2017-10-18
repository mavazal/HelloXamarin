using HelloXamarin.ViewModels;
using HelloXamarin.Views;
using Prism.Unity;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HelloXamarin
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }
        
        protected async override void OnInitialized()
        {
            InitializeComponent();
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<DashboardPage, DashboardPageViewModel>();

        }
        
    }
}
