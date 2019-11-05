using System;
using System.Collections.Generic;
using HevnerApp.DataAccessLayer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace HevnerApp
{
    public partial class App : Application
    {
        
        private static DAL _appDAL = new DAL();

        public static DAL AppDal => _appDAL;

        public App()
        {
            InitializeComponent();
            _appDAL.PopulateTestData();

            MainPage = new NavigationPage(new MainPage())
            {
                BarTextColor = Color.White
            };
            
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