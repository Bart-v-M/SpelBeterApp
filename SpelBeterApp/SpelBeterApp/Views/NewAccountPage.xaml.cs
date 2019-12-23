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
	public partial class NewAccountPage : ContentPage
	{
		public NewAccountPage()
		{
			InitializeComponent();

            // Set info text -->
            Label_pageInfo.Text = info_makeNewAccount;
        }

        // Info text
        string info_makeNewAccount =
            "Je kunt aan een dagelijkse test meedoen als je je registreert bij Spel Beter!" 
            + Environment.NewLine 
            + "Invoervelden met een * zijn verplicht.";        

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            // Set background and text color -->
            App.currentPage = new NavigationPage(new CalendarPage());

            // User logs in with a new account -->
            App.masterDetailPage = new MainPage
            {
                Master = App.menuPage = new MenuPage(),
                Detail = App.currentPage
            };

            // Set current MainPage of the Application -->
            Application.Current.MainPage = App.masterDetailPage;
        }
    }
}