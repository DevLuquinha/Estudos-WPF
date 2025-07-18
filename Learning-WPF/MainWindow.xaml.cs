using Microsoft.Win32;
using System.Windows;

namespace Learning_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fireButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# Source Files | *.cs";
            fileDialog.Title = "Please pick a CS Source File";

            bool? success = fileDialog.ShowDialog();
            if(success == true)
            {
                string path = fileDialog.FileName;
                string fileName = fileDialog.SafeFileName;

                infoTextBlock.Text = fileName;
            }
            else
            {
                // Exit the dialog
            }

        }
    }
}