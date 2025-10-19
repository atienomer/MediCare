using MediCare.Domain.Shared;
using System.Collections.Generic;

namespace MediCare.Domain.Entities
{
    public class Doctor : BaseEntity, IStaff
    {
        // Properties from IStaff
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int NationalId { get; set; }
        public int SpecialtyId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int DepartmentId { get; set; }

        // Navigation property - One doctor can have many patients
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();

        // Optional: Additional Doctor-specific fields
        public string LicenseNumber { get; set; } = string.Empty;
        public int YearsOfExperience { get; set; }

        // Constructor
        public Doctor() { }
    }
}

