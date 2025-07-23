using Learning_WPF.Commands;
using Learning_WPF.Models;
using Learning_WPF.Services;
using Learning_WPF.Stores;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Learning_WPF.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly Hotel _hotel;
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel(Hotel hotel, NavigationService makeReservationNavigationService)
        {
            _hotel = hotel;
            _reservations = new ObservableCollection<ReservationViewModel>();

            MakeReservationCommand = new NavigateCommand(makeReservationNavigationService);

            UpdateReservations();
        }

        private void UpdateReservations()
        {
            _reservations.Clear();

            foreach (Reservation reservation in _hotel.GetAllReservations())
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reservation);
                _reservations.Add(new ReservationViewModel(reservation));
            }
        }
    }
}
