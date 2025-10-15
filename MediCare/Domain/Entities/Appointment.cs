using MediCare.Models;

namespace MediCare.Domain.Entities
{
    public class Appointment: Shared.BaseEntity
    {
        public DateTime AppointmentDate { get; set; }
        public string Reason { get; set; }= string.Empty;
        public ICollection<Doctor> Doctor { get; set; } = new List<Doctor>();
        public Appointment( DateTime appointmentDate, string reason)
        {
            AppointmentDate = appointmentDate;
            Reason = reason;
        }
        public Appointment()
        {
        }
    }
}
