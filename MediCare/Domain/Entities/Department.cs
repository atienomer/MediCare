using MediCare.Domain.Shared;
using MediCare.Models;

namespace MediCare.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public ICollection<Specialty>Specialties { get; set; } = new List<Specialty>();
        public Department(string departmentName,int departmentId)
        {
            DepartmentName = departmentName;
            DepartmentId = departmentId;
        }
    
       public Department()
        {
        }
    }
}


