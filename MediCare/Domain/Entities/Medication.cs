using MediCare.Domain.Shared;

namespace MediCare.Domain.Entities
{
    public class Medication : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;

        // A medication can be associated with multiple lab tests
        public ICollection<LabTest> LabTests { get; set; } = new List<LabTest>();

        // Constructor with parameters
        public Medication(string name, string dosage, string manufacturer)
        {
            Name = name;
            Dosage = dosage;
            Manufacturer = manufacturer;
        }

        // Default constructor
        public Medication()
        {
        }
    }
}

