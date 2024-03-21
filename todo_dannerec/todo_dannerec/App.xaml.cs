﻿using System;
using LotsOfFoodApp.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using LotsOfFoodApp.Views;

namespace todo_dannerec
{
    public partial class App : Application
    {
        private static AppDatabase database;
        internal static AppDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new AppDatabase(Path.Combine(Environment.GetFolderPath
                    (Environment.SpecialFolder.LocalApplicationData), "MenuItems.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MenuPage());
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