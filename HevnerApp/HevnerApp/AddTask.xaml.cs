using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HevnerApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Task = System.Threading.Tasks.Task;

namespace HevnerApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTask : ContentPage
    {
        public AddTask(object parent)
        {
            InitializeComponent();

            List<string> cycleOptions = new List<string>();
            List<string> statusOptions = new List<string>();

            cycleOptions.Add("Relevance");
            cycleOptions.Add("Design");
            cycleOptions.Add("Rigor");
            
            statusOptions.Add("To-do");
            statusOptions.Add("In Progress");
            statusOptions.Add("Done");
            
            TaskCyclePicker.ItemsSource = cycleOptions;
            TaskStatusPicker.ItemsSource = statusOptions;
        }

    private void AddTaskButton_OnClicked(object sender, EventArgs e)
        {
            // Add Note and return to previous page if all fields have been filled in
            if (TaskNameEntry.Text != "" && TaskDescriptionEntry.Text != "" && TaskCyclePicker.SelectedIndex != -1 && TaskStatusPicker.SelectedIndex != -1)
            {
                
            }
        }
    }
}