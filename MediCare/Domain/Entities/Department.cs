using MediCare.Domain.Shared;
using MediCare.Models;

namespace MediCare.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; } = string.Empty;

        // A department can have multiple specialties
        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

        // Constructor with parameters
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }

        // Default constructor
        public Department()
        {
        }
    }
}



