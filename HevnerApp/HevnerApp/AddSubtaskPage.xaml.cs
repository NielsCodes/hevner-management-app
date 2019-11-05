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
            if (SubtaskNameEntry.Text != "" && SubtaskDescriptionEntry.Text != "" && SubtaskStatusPicker.SelectedIndex != -1)
            {
                Navigation.PopAsync();
            }
        }
    }
}