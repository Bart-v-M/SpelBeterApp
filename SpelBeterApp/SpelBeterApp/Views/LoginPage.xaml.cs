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
		public LoginPage ()
		{
			InitializeComponent();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //
            App.currentPage = new NavigationPage(new CalenderPage())
            {
                BarBackgroundColor = Constants.backgroundColor,
                BarTextColor = Constants.textColor
            };

            // User logs in and is verified -->
            App.masterDetailPage = new MainPage();
       
            App.masterDetailPage.Detail = App.currentPage;
            App.masterDetailPage.Master = (App.masterPage = new MenuPage());

            App.Current.MainPage = App.masterDetailPage;
        }

        private void Label_goToMakeAccountButton_Clicked(object sender, EventArgs e)
        {
            async void NavigateTo()
            {
                await Navigation.PushAsync(new NewAccountPage());
            }
            NavigateTo();
        }
    }
}