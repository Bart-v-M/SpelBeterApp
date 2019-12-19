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
            NavigateTo(new MainPage());
        }

        private void Label_goToMakeAccountButton_Clicked(object sender, EventArgs e)
        {
            NavigateTo(new NewAccountPage());
        }

        private async void NavigateTo(Page page)
        {
            await Navigation.PushAsync(page);
        }    
    }
}