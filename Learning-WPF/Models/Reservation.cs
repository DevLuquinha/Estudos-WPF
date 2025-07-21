namespace Learning_WPF.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public string UserName { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        public TimeSpan Length => EndTime.Subtract(StartTime);
        
        public Reservation(RoomID roomID, string username,DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            UserName = username;
            StartTime = startTime;
            EndTime = EndTime;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if(reservation.RoomID != RoomID)
            {
                return false;
            }

            return reservation.StartTime < reservation.EndTime || reservation.EndTime > reservation.StartTime;
        }
    }
}
