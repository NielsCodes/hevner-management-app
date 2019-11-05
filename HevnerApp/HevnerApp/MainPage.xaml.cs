using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace HevnerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            // Disable the header for the login page
            NavigationPage.SetHasNavigationBar(this, false);
            
            // Resize viewport when keyboard is opened (Prevents keyboard from blocking inputs)
            App.Current.On<Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
        }

        private void LogInButton_OnClicked(object sender, EventArgs e)
        {

            bool emailEmpty = string.IsNullOrEmpty(EmailEntry.Text);
            bool passEmpty = string.IsNullOrEmpty(PassEntry.Text);
            
            // Navigation is only performed when values are entered
            if (!emailEmpty && !passEmpty)
            {
                Navigation.PushAsync(new ProjectsListPage());
            }
        }


        private void PasswordResetLink_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PasswordResetPage());
        }
    }
}