namespace Learning_WPF.Models
{
    public class ReservationBook
    {
        private readonly Dictionary<RoomID, List<Reservation>> _roomsToReservation;

        public ReservationBook()
        {
            _roomsToReservation = new Dictionary<RoomID, List<Reservation>>();
        }
    }
}
