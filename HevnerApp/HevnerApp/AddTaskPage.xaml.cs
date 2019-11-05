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
    public partial class AddTaskPage : ContentPage
    {

        public AddTaskPage(object parent)
        {
            InitializeComponent();

            Title = "Taak toevoegen";

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
        bool nameEmpty = string.IsNullOrEmpty(TaskNameEntry.Text);
        bool descriptionEmpty = string.IsNullOrEmpty(TaskDescriptionEntry.Text);
            
            // Add Note and return to previous page if all fields have been filled in
            if (!nameEmpty && !descriptionEmpty && TaskCyclePicker.SelectedIndex != -1 && TaskStatusPicker.SelectedIndex != -1)
            {

                Navigation.PopAsync();
                
            }
        }
    }
}