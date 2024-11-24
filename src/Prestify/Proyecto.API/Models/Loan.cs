namespace Prestify.Web.Models
{
    public class Loan
    {
        public string LoanNumber { get; set; }
        public decimal Amount { get; set; }
        public int Rate { get; set; }
        public int Term { get; set; }
        public DateTime EndDate { get; set; }
        //public bool Active { get; set; }
        public bool Inactive { get; set; }

    }
}
