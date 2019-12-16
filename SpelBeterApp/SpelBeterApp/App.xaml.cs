﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpelBeterApp.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SpelBeterApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MainPage = new LoginPage();
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
