using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HevnerApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProjectPage : ContentPage
    {
        public AddProjectPage()
        {
            InitializeComponent();

            Title = "Project toevoegen";
        }

        private void AddProjectButton_OnClicked(object sender, EventArgs e)
        {
            // Logic to add project to database

            // Redirect user back to projects overview
            Navigation.PopAsync();
        }
    }
}