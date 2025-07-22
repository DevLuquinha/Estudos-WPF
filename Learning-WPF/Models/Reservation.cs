namespace Learning_WPF.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public string UserName { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public TimeSpan Length => EndDate.Subtract(StartDate);
        
        public Reservation(RoomID roomID, string username,DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            UserName = username;
            StartDate = startTime;
            EndDate = EndDate;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if(reservation.RoomID != RoomID)
            {
                return false;
            }

            return reservation.StartDate < reservation.EndDate || reservation.EndDate > reservation.StartDate;
        }
    }
}
