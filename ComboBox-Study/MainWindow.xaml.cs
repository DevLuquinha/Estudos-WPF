using System.Collections.ObjectModel;
using System.Windows;
namespace ComboBox_Study;

public partial class MainWindow : Window
{
    public ObservableCollection<Client> Clients { get; set; }
    public MainWindow()
    {
        InitializeComponent();

        Clients = new ObservableCollection<Client>
        {
            new Client { Name = "John", LastName = "Doe", Phone = "123-456-7890" },
            new Client { Name = "Jane", LastName = "Smith", Phone = "987-654-3210" },
            new Client { Name = "Alice", LastName = "Johnson", Phone = "555-555-5555" }
        };
    }
}