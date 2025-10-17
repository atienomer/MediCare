using MediCare.Domain.Shared;
using MediCare.Models;

namespace MediCare.Domain.Entities
{
    public class Specialty : BaseEntity
    {
        public string SpecialtyName { get; set; } = string.Empty;
        public int SpecialtyId { get; set; } 
        public int DepartmentId { get; set; } 
        public int DoctorId { get; set; } //foreign key
        public new int NurseId { get; set; } //foreign key
        public new int PatientId { get; set; } //foreign key

        public new Doctor Doctor { get; set; } = null!; //navigation property
        public new Nurse Nurse { get; set; } = null!; //navigation property
        public new Patient Patient { get; set; } = null!; //navigation property

        public Specialty(string specialtyName, int specialtyId, int departmentId, int doctorId,int nurseId,int patientId)
        {
            SpecialtyName = specialtyName;
            SpecialtyId = specialtyId;
            DepartmentId = departmentId;
            DoctorId = doctorId;
            NurseId = nurseId;
            PatientId = patientId;

        }
    
       public Specialty()
        {
        }
    }
}