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
    public partial class AddSubtaskPage : ContentPage
    {
        public AddSubtaskPage()
        {
            InitializeComponent();

            Title = "Subtaak toevoegen";
        }

        private void AddSubtaskButton_OnClicked(object sender, EventArgs e)
        {

            bool nameEmpty = string.IsNullOrEmpty(SubtaskNameEntry.Text);
            bool descriptionEmpty = string.IsNullOrEmpty(SubtaskDescriptionEntry.Text);
            
            if (!nameEmpty && !descriptionEmpty && SubtaskStatusPicker.SelectedIndex != -1)
            {
                Navigation.PopAsync();
            }
        }
    }
}