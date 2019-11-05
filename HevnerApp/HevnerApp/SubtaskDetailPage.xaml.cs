using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HevnerApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HevnerApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubtaskDetailPage : ContentPage
    {

        private Subtask _subtask;
        
        public SubtaskDetailPage(Subtask subtask)
        {
            InitializeComponent();

            Title = subtask.Name;
            descriptionLabel.Text = subtask.Description;
        }

        private void ShowNotesToolbarItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotesPage(_subtask.Notes));
        }

        private void ShowHelpToolbarItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HelpPage());
        }
    }
}