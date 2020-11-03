﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BucketList.Services;
using BucketList.Views;

namespace BucketList
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();     // new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
