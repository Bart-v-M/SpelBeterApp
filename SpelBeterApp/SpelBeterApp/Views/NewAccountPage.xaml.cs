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

            Label_mandatoryInput.Text = info_makeNewAccount;
            NavigationPage.SetHasBackButton(this, true);
		}

        string info_makeNewAccount =
            "Je kunt aan een dagelijkse test meedoen als je je registreert bij Spel Beter!" 
            + Environment.NewLine 
            + "Invoervelden met een* zijn verplicht.";        

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            NavigateTo(new MainPage());
        }

        private async void NavigateTo(Page page)
        {
            await Navigation.PushModalAsync(page);
        }
    }
}