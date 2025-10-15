using MediCare.Domain.Shared;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace MediCare.Domain.Entities
{
    public class Doctor:BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Speciality { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<Patient> Patient { get; set; } = new List<Patient>();//list of patients associate with the doctor
        public Doctor(string firstName,string lastName,string speciality, string phoneNumber, string email) 
        {
            FirstName = firstName;
            LastName = lastName;
            Speciality = speciality;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public Doctor() 
        {
        }

    }
}
