using MediCare.Domain.Shared;

namespace MediCare.Domain.Entities
{
    public class Nurse : Shared.BaseEntity,Staff
    {
        
        public ICollection<Patient> Patient { get; set; } = new List<Patient>();
       
        public Nurse()
        {
        }
    }
}
