using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HevnerApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Task = HevnerApp.Models.Task;

namespace HevnerApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskDetailPage : ContentPage
    {

        private Task _task;
        
        public TaskDetailPage(Task task)
        {
            InitializeComponent();

            Title = task.Name;
            _task = task;
            descriptionLabel.Text = task.Description;

            SubtaskListView.ItemsSource = task.Subtasks;
        }

        private void SubtaskListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            var selectedItem = e.Item as Subtask;
            Navigation.PushAsync(new SubtaskDetailPage(selectedItem));
        }

        private void ShowHelpToolbarItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HelpPage());
        }

        private void ShowNotesToolbarItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotesPage(_task.Notes));
        }

        private void AddSubTaskToolbarItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddSubtaskPage());
        }
    }
}