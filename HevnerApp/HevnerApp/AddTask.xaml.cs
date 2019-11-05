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

//                int id = 1;
//                int createdBy = 1;
//                string createdAt = "01-01-2019";
//                int parentId;
//
//                switch (_parentType)
//                {
//                    case Note.ParentTypes.Project:
//                        parentId = _parentProject.Id;
//                        break;
//                    case Note.ParentTypes.Task:
//                        parentId = _parentTask.Id;
//                        break;
//                    case Note.ParentTypes.Subtask:
//                        parentId = _parentSubtask.Id;
//                        break;
//                }
//                
//                string cycle;
//                string status;
//                
//                switch (TaskCyclePicker.SelectedItem)
//                {
//                    case "Relevance":
//                        cycle = "relevance";
//                        break;
//                    case "Design":
//                        cycle = "design";
//                        break;
//                    case "Rigor":
//                        cycle = "rigor";
//                        break;
//                }
//
//                switch (TaskStatusPicker.SelectedItem)
//                {
//                    case "To-do":
//                        status = "to   do";
//                        break;
//                    case "In Progress":
//                        status = "progress";
//                        break;
//                    case "Done":
//                        status = "done";
//                        break;
//                }
//                
//                
//                Note newNote = new Note(id, parentId, _parentType,  );

                Navigation.PopAsync();
                
            }
        }
    }
}