namespace CustomerPortal.Server.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public String Email { get; set; }
        public String Name { get; set; }
        public String PhoneNumber { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Postcode { get; set; }

        //status of Active/Inactive
        public String Status { get; set; }
        public DateTime Created { get; set; }
    }
}
