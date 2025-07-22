using Learning_WPF.Models;
using System.Globalization;

namespace Learning_WPF.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;

        public string RoomID => _reservation.RoomID?.ToString();
        public string Username => _reservation.UserName;
        public string StartDate => _reservation.StartDate.ToString("d");
        public string EndDate => _reservation.EndDate.ToString("d");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
