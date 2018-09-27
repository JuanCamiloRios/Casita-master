using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Casita
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var NavigationPage = new NavigationPage(new MainPage());
            var color = "#ff0000";
            NavigationPage.BarBackgroundColor = Color.FromHex(color);
            NavigationPage.BarTextColor = Color.White;
            MainPage = NavigationPage;

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
