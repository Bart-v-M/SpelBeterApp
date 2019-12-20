using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpelBeterApp.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SpelBeterApp
{
    public partial class App : Application
    {
        public static NavigationPage currentPage; // current detail page
        public static CalenderPage calenderPage;

        // This is the master detail page. It contains both the master and detail page. The detail page can be swapped by the user via the master page. (Navigation side menu)
        public static MainPage masterDetailPage;

        // This is the side menu. Used for navigation. This will swap detail pages.
        public static MenuPage masterPage;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage())
            {
                BarBackgroundColor = Color.Firebrick,
                BarTextColor = Color.White
            };
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
