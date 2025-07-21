using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;

namespace Learning_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            entries = new ObservableCollection<string>();

            InitializeComponent();
        }

        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(entryTextBox.Text);
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            string item = (string)entriesListView.SelectedItem;
            Entries.Remove(item);
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            Entries.Clear();
        }
    }
}