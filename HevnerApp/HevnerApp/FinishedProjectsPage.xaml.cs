using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HevnerApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HevnerApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinishedProjectsPage : ContentPage
    {
        public FinishedProjectsPage(List<Project> projects)
        {
            InitializeComponent();

            Title = "Afgeronde onderzoeken";

            FinishedProjectsListView.ItemsSource = projects;
        }
    }
}