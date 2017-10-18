using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
            }
            
        }
    }
}