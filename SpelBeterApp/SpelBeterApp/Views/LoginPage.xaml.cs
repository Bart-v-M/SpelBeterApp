using SpelBeterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpelBeterApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

        private void Label_LoginButton_Tapped(object sender, EventArgs e)
        { 
            // Set background and text color -->
            App.currentPage = new NavigationPage(new CalenderPage())
            {
                BarBackgroundColor = Constants.backgroundColor,
                BarTextColor = Constants.textColor
            };

            // User logs in and is verified -->
            App.masterDetailPage = new MainPage
            {
                Detail = App.currentPage,
                Master = App.menuPage = new MenuPage()
            };

            // Set current MainPage of Application
            Application.Current.MainPage = App.masterDetailPage; 
        }

        private void Label_goToMakeAccountButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewAccountPage());
        }
    }
}
