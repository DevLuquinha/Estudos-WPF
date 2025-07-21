using System.Collections;
using System.Windows;

namespace Learning_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            entriesListView.Items.Add("a");
            entriesListView.Items.Add("b");
            entriesListView.Items.Add("c");
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            entriesListView.Items.Add(entryTextBox.Text);
            entryTextBox.Clear();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            //int index = entriesListView.SelectedIndex;
            //object item = entriesListView.SelectedItem;
            var items = entriesListView.SelectedItems;
            var result = MessageBox.Show($"Are you sure you want to delete {items.Count} items?", "Sure?", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                var itemList = new ArrayList(items);
                foreach(var item in itemList)
                    entriesListView.Items.Remove(item);
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            entriesListView.Items.Clear();
        }
    }
}