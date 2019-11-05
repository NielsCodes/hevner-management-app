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
    public partial class NotesPage : ContentPage
    {
        public NotesPage(List<Note> notes)
        {
            InitializeComponent();

            Title = "Notities";

            NotesListView.ItemsSource = notes;

        }
    }
}