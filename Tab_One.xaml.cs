using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using TestSharedProperties.Settings;

namespace TestSharedProperties
{
    /// <summary>
    /// First page.
    /// </summary>
    public sealed partial class Tab_One : Page
    {
        public TestVM Test { get; }
        public Tab_One()
        {
            Test = new TestVM();
            this.InitializeComponent();
        }

        private void test2Button_Click(object sender, RoutedEventArgs e)
        {
            TestVM TestCfg = new();
            test2.Text = TestCfg.TestSwitch.ToString();
        }
    }
}
