using MediCare.Domain.Shared;
using MediCare.Models;

namespace MediCare.Domain.Entities
{
    public class Patient : BaseEntity
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } 
        public string Email { get; set; }
        public ICollection<Doctor> Doctor { get; set; } = new List<Doctor>();//list of doctors associated with the patient
        public Patient (string firstName, string lastName,DateTime dateOfBirth, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
       public Patient()
        {
        }
    }
}
