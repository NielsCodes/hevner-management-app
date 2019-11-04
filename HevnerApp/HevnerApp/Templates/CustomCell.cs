using Xamarin.Forms;

namespace HevnerApp.Templates
{
    public class CustomCell : ViewCell
    {
        public CustomCell()
        {
            StackLayout cellWrapper = new StackLayout();
            StackLayout contentWrapper = new StackLayout();
            Label projectName = new Label();
            Label projectDescription = new Label();
            
            projectName.SetBinding(Label.TextProperty, "Name");
            projectDescription.SetBinding(Label.TextProperty, "Description");
            
            contentWrapper.Children.Add(projectName);
            contentWrapper.Children.Add(projectDescription);
            cellWrapper.Children.Add(contentWrapper);
            View = cellWrapper;

        }
        
    }
}