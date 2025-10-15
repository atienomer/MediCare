namespace MediCare.Domain.Entities
{
    public class Medication:Shared.BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public ICollection<Labtest> Labtest { get; set; } = new List<Labtest>();
        public Medication(Guid id, string name, string dosage, string manufacturer)
        {
            Name = name;
            Dosage = dosage;
            Manufacturer = manufacturer;
        }
        public Medication()
        {
        }
    }
}
