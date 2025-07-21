using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;

namespace Learning_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void detailsButton_Click(object sender, RoutedEventArgs e)
        {
            detailsExpander.IsExpanded = !detailsExpander.IsExpanded;
        }
    }
}