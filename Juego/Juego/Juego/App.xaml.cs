﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Juego
{
    public partial class App : Application
    {
        private NavigationPage Page;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            Page = new NavigationPage(new visualizarjuego());
            Page = new NavigationPage(new Inicio());
            Page = new NavigationPage(new registro());

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
