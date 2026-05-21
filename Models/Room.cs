namespace hostelmanagement.Models
{
    public class Room
    {
        public int RoomNumber { get; set; }

        public string HostelName { get; set; }

        public int Capacity { get; set; }

        public int CurrentOccupancy { get; set; }
    }
}