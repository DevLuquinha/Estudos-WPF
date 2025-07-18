using System.Windows;

namespace Learning_WPF
{
    public partial class MainWindow : Window
    {
        bool running = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void toggleRunButton_Click(object sender, RoutedEventArgs e)
        {
            if(running)
            {
                statusTextBlock.Text = "Stopped";
                toggleRunButton.Content = "Run";
            }
            else
            {
                statusTextBlock.Text = "Running";
                toggleRunButton.Content = "Stop";
            }

            running = !running;
        }
    }
}