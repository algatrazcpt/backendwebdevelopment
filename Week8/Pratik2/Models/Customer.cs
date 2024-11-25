namespace Pratik2.Models
{
    public class Customer
    {
        int customerId;
        string firstName="";
        string lastName="";
        string email="";
        public int CustomerId { get {  return customerId; } set {  customerId = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
