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
    public partial class ProjectPage : TabbedPage
    {
        public ProjectPage(Project project)
        {
            InitializeComponent();

            if (project == null)
            {
                throw new ArgumentException("Project argument not passed");
            }

            Title = project.Name;
            
            List<Task> allTasks = project.Tasks;
            List<Task> relevanceTasks = new List<Task>();
            List<Task> designTasks = new List<Task>();
            List<Task> rigorTasks = new List<Task>();
            
            // Loop through all tasks to filter in which cycle they are, but only if there are tasks
            if (allTasks.Count > 0)
            {
                foreach (Task task in allTasks)
                {
                    switch (task.Cycle)
                    {
                        case "relevance":
                            relevanceTasks.Add(task);
                            break;
                        case "design":
                            designTasks.Add(task);
                            break;
                        case "rigor":
                            rigorTasks.Add(task);
                            break;
                    }
                }
                
                Children.Add(new TasksPage("Alle cycli", allTasks));
                Children.Add(new TasksPage("Relevance", relevanceTasks));
                Children.Add(new TasksPage("Design", designTasks));
                Children.Add(new TasksPage("Rigor", rigorTasks));
                
            }
            
        }
    }
}