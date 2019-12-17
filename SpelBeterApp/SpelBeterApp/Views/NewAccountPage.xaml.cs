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
	public partial class NewAccountPage : ContentPage
	{
		public NewAccountPage()
		{
			InitializeComponent();

            // Set info text
            Label_mandatoryInput.Text = info_makeNewAccount;
		}

        string info_makeNewAccount =
            "Je kunt aan een dagelijkse test meedoen als je je registreert bij Spel Beter!" 
            + Environment.NewLine 
            + "Invoervelden met een * zijn verplicht.";        

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            NavigateTo(new MainPage());
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            NavigateTo(new LoginPage());
        }

        private async void NavigateTo(Page page)
        {
            await Navigation.PushModalAsync(new NavigationPage(page));
        }
    }
}