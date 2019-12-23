using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SpelBeterApp.Models;
using SpelBeterApp.Views;
using SpelBeterApp.ViewModels;

namespace SpelBeterApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        CalendarViewModel viewModel;

        public CalendarPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new CalendarViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new CalendarDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        /*
        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }
        */

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}