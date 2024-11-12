namespace Project_.NET.Properties
{
    public class Customer
    {
        private int id { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string email { get; set; }
        private string phoneNumber { get; set; }
        private string address { get; set; }  

       
        public Customer(int id,string firstName, string lastName, string email, string phoneNumber, string address)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }
        
        public string FullName => $"{firstName} {lastName}";

    }
    
}
