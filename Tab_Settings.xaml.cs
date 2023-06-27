using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using TestSharedProperties.Settings;

namespace TestSharedProperties
{
    /// <summary>
    /// Settings page for common settings
    /// </summary>
    public partial class Tab_Settings : Page
    {
        public TestVM Test { get; set; } = new();
        public Tab_Settings()
        {
            InitializeComponent();
        }

        private void Test1Toggle_Toggled(object sender, RoutedEventArgs e)
        {
            //Test.TestSwitch = TestToggle.IsOn;
        }
    }
}
