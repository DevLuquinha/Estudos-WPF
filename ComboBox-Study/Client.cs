using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ComboBox_Study
{
    public class Client : INotifyPropertyChanged
    {
		private string _name;
        private string _lastName;
		private string _phone;
		
		public event PropertyChangedEventHandler? PropertyChanged;
		
		public string Name
		{
			get => _name;
            set 
			{ 
				if(_name != value)
				{
                    _name = value;
					OnPropertyChanged();
                }
			}
		}

        public string LastName
        {
			get => _lastName;
            set 
			{ 
				if(_lastName != value)
				{
					_lastName = value; 
					OnPropertyChanged();
                }
			}
        }

		public string Phone
		{
			get => _phone;
			set 
			{ 
				if(_phone != value)
				{
                    _phone = value;
                    OnPropertyChanged();
                }
            }
		}

		public void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
