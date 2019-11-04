using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HevnerApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectsListPage : ContentPage
    {
        
        public ProjectsListPage()
        {
            InitializeComponent();
            Title = "Projects";
        }

        private void AddProjectToolbarItem_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException("New project page not yet implemented");
        }

        private void ShowCompletedProjectsToolbarItem_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException("Previously completed projects page not yet implemented");
        }

        private void ShowHelpToolbarItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HelpPage());
        }
    }
}