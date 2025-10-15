using MediCare.Models;

namespace MediCare.Domain.Entities
{
    public class Appointment
    {
        public DateTime AppointmentDate { get; set; }
        public string Reason { get; set; }
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
