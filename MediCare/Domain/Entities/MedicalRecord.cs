namespace MediCare.Domain.Entities
{
    public class MedicalRecord: Shared.BaseEntity
    {
      
        public string Diagnosis { get; set; } = string.Empty;
        public string Treatment { get; set; } = string.Empty; 
        public DateTime RecordDate { get; set; }
        public ICollection<Patient> Patient { get; set; } = new List<Patient>();
        public MedicalRecord(string diagnosis, string treatment, DateTime recordDate)
        {
            
            Diagnosis = diagnosis;
            Treatment = treatment;
            RecordDate = recordDate;
        }
        public MedicalRecord()
        {
        }
    }
}
