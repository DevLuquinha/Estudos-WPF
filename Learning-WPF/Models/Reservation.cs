namespace Learning_WPF.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Length => EndTime.Subtract(StartTime);
        public Reservation(RoomID roomID, DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            StartTime = startTime;
            EndTime = EndTime;
        }
    }
}
