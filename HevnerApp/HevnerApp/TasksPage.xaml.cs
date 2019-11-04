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
    public partial class TasksPage : ContentPage
    {
        public TasksPage(string title, List<Task> tasks)
        {
            InitializeComponent();

            TaskListView.ItemsSource = tasks;
            Title = title;

        }

        private void TaskListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddTaskToolbarItem_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowNotesToolbarItem_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowHelpToolbarItem_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}