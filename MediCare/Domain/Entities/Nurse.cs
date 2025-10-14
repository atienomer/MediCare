namespace MediCare.Domain.Entities
{
    public class Nurse : Shared.BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<Patient> Patient { get; set; } = new List<Patient>();
        public Nurse(string firstName, string lastName, string department, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
