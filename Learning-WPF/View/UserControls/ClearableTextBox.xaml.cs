using System.Windows;
using System.Windows.Controls;

namespace Learning_WPF.View.UserControls
{
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set 
            { 
                placeholder = value;
                placeHolderTextBlock.Text = placeholder;
            }
        }


        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBox.Clear();
            inputTextBox.Focus();
        }

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(inputTextBox.Text))
                placeHolderTextBlock.Visibility = Visibility.Visible;
            else
                placeHolderTextBlock.Visibility = Visibility.Hidden;
        }
    }
}
