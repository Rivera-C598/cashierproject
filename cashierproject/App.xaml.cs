using cashierproject.Helpers;
using System;
using Xamarin.Forms;

namespace cashierproject
{


    public partial class App : Application
    {
        public static DatabaseHelper DatabaseHelper { get; private set; }

        public App(string dbPath)
        {
            InitializeComponent();

            DatabaseHelper = new DatabaseHelper(dbPath);

            MainPage = new MainPage();
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
