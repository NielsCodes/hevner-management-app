using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace HevnerApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PasswordResetPage : ContentPage
    {
        public PasswordResetPage()
        {
            InitializeComponent();

            Title = "Reset wachtwoord";

            // Resize viewport when keyboard is opened (Prevents keyboard from blocking inputs)
            App.Current.On<Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
        }

        private void ResetPasswordButton_OnClicked(object sender, EventArgs e)
        {
            // Return to login page
            Navigation.PopToRootAsync();
        }
    }
}