using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HevnerApp.Models;
using HevnerApp.Templates;
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
            Title = "Projecten";

            // TODO: Implement custom template for three line items
            // ProjectsListView.ItemTemplate = new DataTemplate(typeof(CustomCell));
            
            ProjectsListView.ItemsSource = App.AppDal.Projects;

        }

        private void AddProjectToolbarItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddProjectPage());
        }

        private void ShowCompletedProjectsToolbarItem_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException("Previously completed projects page not yet implemented");
        }

        private void ShowHelpToolbarItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HelpPage());
        }

        private void ProjectsListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            var selectedItem = e.Item as Project;
            Navigation.PushAsync(new ProjectPage(selectedItem));
        }
        
    }
}