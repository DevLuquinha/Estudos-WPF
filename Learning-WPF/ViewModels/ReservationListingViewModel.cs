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
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public MakeReservationViewModel MakeReservationViewModel { get; }


        public ICommand LoadReservationsCommand { get; }
        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel(
            HotelStore hotelStore,
            MakeReservationViewModel makeReservationViewModel,
            NavigationService makeReservationNavigationService)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            MakeReservationViewModel = makeReservationViewModel;

            LoadReservationsCommand = new LoadReservationsCommand(this, hotelStore);
            MakeReservationCommand = new NavigateCommand(makeReservationNavigationService);
        }

        public static ReservationListingViewModel LoadViewModel(
            HotelStore hotelStore,
            MakeReservationViewModel makeReservationViewModel,
            NavigationService makeReservationNavigationService)
        {
            ReservationListingViewModel viewModel = new ReservationListingViewModel(hotelStore, makeReservationViewModel, makeReservationNavigationService);

            viewModel.LoadReservationsCommand.Execute(null);

            return viewModel;
        }

        public void UpdateReservations(IEnumerable<Reservation> reservations)
        {
            _reservations.Clear();

            foreach (Reservation reservation in reservations)
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reservation);
                _reservations.Add(new ReservationViewModel(reservation));
            }
        }
    }
}
