using MediCare.Domain.Shared;

namespace MediCare.Domain.Entities
{
    public class MedicalRecord : BaseEntity
    {
        public string Diagnosis { get; set; } = string.Empty;
        public string Treatment { get; set; } = string.Empty;
        public DateTime RecordDate { get; set; }

        // Each medical record is linked to one patient
        public int PatientId { get; set; }
        public Patient Patient { get; set; } = new Patient();

        // Constructor with parameters
        public MedicalRecord(string diagnosis, string treatment, DateTime recordDate)
        {
            Diagnosis = diagnosis;
            Treatment = treatment;
            RecordDate = recordDate;
        }

        // Default constructor
        public MedicalRecord()
        {
        }
    }
}

