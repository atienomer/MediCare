namespace MediCare.Domain.Entities
{
    public class Nurse : Shared.BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<Patient> Patient { get; set; } = new List<Patient>();
        public Nurse(string firstName, string lastName, string department, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public Nurse()
        {
        }
    }
}
