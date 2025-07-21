using System.Windows;

namespace Learning_WPF.View
{
    public partial class ModalWindow : Window
    {
        public bool Success { get; set; }
        public string Input { get; set; }
        public ModalWindow(Window parentWindow)
        {
            Owner = parentWindow;
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = inputTextBox.Text;
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void inputTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(inputTextBox.Text))
                okButton.IsEnabled = true;
            else okButton.IsEnabled = false;
        }
    }
}
