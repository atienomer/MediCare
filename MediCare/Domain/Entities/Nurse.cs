using MediCare.Domain.Shared;
using MediCare.Domain.Shared;
using System.Collections.Generic;

namespace MediCare.Domain.Entities
{
    public class Nurse : BaseEntity, IStaff
    {
        // Properties from IStaff
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int NationalId { get; set; }
        public int SpecialtyId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int DepartmentId { get; set; }

        // Relationship with Patients
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();

        // Optional: Add Nurse-specific fields
        public string Shift { get; set; } = "Day";

        public Nurse() { }
    }
}

