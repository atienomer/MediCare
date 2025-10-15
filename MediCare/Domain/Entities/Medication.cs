namespace MediCare.Domain.Entities
{
    public class Medication
    {
        public string Name { get; set; } 
        public string Dosage { get; set; } 
        public string Manufacturer { get; set; }
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
