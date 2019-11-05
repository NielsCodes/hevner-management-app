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
    public partial class AddNotePage : ContentPage
    {
        public AddNotePage()
        {
            InitializeComponent();

            Title = "Notitie toevoegen";
        }

        private void AddNoteButton_OnClicked(object sender, EventArgs e)
        {
            // Check whether field was filled in
            if (NoteEditor.Text != "")
            {
                Navigation.PopAsync();
            }
        }
    }
}