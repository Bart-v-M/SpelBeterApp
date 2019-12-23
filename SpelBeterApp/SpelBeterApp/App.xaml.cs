using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpelBeterApp.Views;
using SpelBeterApp.Models;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SpelBeterApp
{
    public partial class App : Application
    {
        // Current detail page.
        public static NavigationPage currentPage;

        // Master detail page: it contains both the master and the detail page. 
        public static MainPage masterDetailPage;

        // This is the side menu page used for navigation. It swaps detail pages.
        public static MenuPage menuPage;

        // Initialization of the app and the mainpage, which starts at the login page.
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
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



//Code used before:
//public static CalenderPage calenderPage;