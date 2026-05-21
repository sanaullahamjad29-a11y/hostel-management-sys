namespace hostelmanagement.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public int StudentID { get; set; }

        public int Amount { get; set; }

        public string Month { get; set; }

        public string Status { get; set; }
    }
}
