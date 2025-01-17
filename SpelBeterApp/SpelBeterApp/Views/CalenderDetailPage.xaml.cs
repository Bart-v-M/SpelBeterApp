﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SpelBeterApp.Models;
using SpelBeterApp.ViewModels;

namespace SpelBeterApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        CalenderDetailViewModel viewModel;

        public ItemDetailPage(CalenderDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new CalenderDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}