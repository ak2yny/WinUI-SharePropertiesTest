using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using TestSharedProperties.Settings;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TestSharedProperties
{
    /// <summary>
    /// The main window contains the banner and navigation panel, as well as common elements.
    /// </summary>
    public sealed partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Navigation View: Determine the selected page, when not already selected.
        /// </summary>
        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected == true)
            {
                NavView_Navigate(typeof(Tab_Settings), args.RecommendedNavigationTransitionInfo);
            }
            else if (args.SelectedItemContainer != null)
            {
                Type navPageType = Type.GetType(args.SelectedItemContainer.Tag.ToString());
                NavView_Navigate(navPageType, args.RecommendedNavigationTransitionInfo);
            }
        }
        /// <summary>
        /// Navigation View: Initial commands. Load home page.
        /// </summary>
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            NavView.SelectedItem = NavView.MenuItems[0];
        }
        /// <summary>
        /// Navigation View: Change the page/tab according to the selection.
        /// </summary>
        private void NavView_Navigate(Type navPageType, NavigationTransitionInfo transitionInfo)
        {
            // Get the page type before navigation so you can prevent duplicate entries in the backstack.
            Type preNavPageType = ContentFrame.CurrentSourcePageType;

            // Only navigate if the selected page isn't currently loaded.
            if (navPageType is not null && !Equals(preNavPageType, navPageType))
            {
                ContentFrame.Navigate(navPageType, null, transitionInfo);
            }
        }

        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {
            //Test3.Text = TestVM.Instance.TestSwitch.ToString();
            TestVM TestCfg = new TestVM();
            Test3.Text = TestCfg.TestSwitch.ToString();

        }
    }
}
