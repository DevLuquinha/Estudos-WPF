using System.Windows;
using Learning_WPF.View;

namespace Learning_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void normalButton_Click(object sender, RoutedEventArgs e)
        {
            NormalWindow normalWindow = new NormalWindow();
            normalWindow.Show();
        }

        private void modalButton_Click(object sender, RoutedEventArgs e)
        {
            ModalWindow modalWindow = new ModalWindow(this);
            Opacity = 0.4;
            
            modalWindow.ShowDialog();

            Opacity = 1;
            if(modalWindow.Success)
            {
                inputTextBox.Text = modalWindow.Input;
            }
        }
    }
}