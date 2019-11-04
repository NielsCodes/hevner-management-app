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

            List<Task> allTasks = project.Tasks;
            
            Children.Add(new TasksPage( "Alle taken" ,allTasks));
            
        }
    }
}