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

            if (tasks.Count != 0) return;
            Label emptyPageLabel = new Label();
            emptyPageLabel.Text = "Geen taken gevonden";
            emptyPageLabel.VerticalOptions = LayoutOptions.CenterAndExpand;
            emptyPageLabel.HorizontalOptions = LayoutOptions.CenterAndExpand;
            EmptyPagePlaceHolder.Children.Add(emptyPageLabel);

        }

        // TODO: Add toolbar links
        private void TaskListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            var selectedItem = e.Item as Task;
            Navigation.PushAsync(new TaskDetailPage(selectedItem));
        }
        
    }
}