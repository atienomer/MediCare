using MediCare.Domain.Shared;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace MediCare.Domain.Entities
{
    public class Doctor : BaseEntity, Staff
    {
        
        public ICollection<Patient> Patient { get; set; } = new List<Patient>();//list of patients associate with the doctor
        
        public Doctor() 
        {
        }

    }
}
