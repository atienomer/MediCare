using MediCare.Models;

namespace MediCare.Domain.Entities
{
    public class Appointment : Shared.BaseEntity
    {
        public DateTime AppointmentDate { get; set; }
        public string Reason { get; set; } = string.Empty;

        // Reference to one doctor (or make this ICollection<Doctor> if you want multiple doctors)
        public Doctor Doctor { get; set; }

        // Reference to the patient attending this appointment
        public Patient Patient { get; set; }

        // Parameterized constructor
        public Appointment(DateTime appointmentDate, string reason)
        {
            AppointmentDate = appointmentDate;
            Reason = reason;
        }

        // Default constructor
        public Appointment()
        {
        }
    }
}

