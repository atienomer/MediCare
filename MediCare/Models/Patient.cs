namespace MediCare.Models;

public class Patient
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }= string.Empty;
    public string Email { get; set; } = string.Empty; 
    public Patient(Guid id, string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        PhoneNumber = phoneNumber;
        Email = email;
    }
    public Patient() 
    {
    }
    public static Patient Create(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email)
    {
        return new Patient
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            DateOfBirth = dateOfBirth,
            PhoneNumber = phoneNumber,
            Email = email
        };
    }
}
public class Doctor
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Doctor(Guid id, string firstName, string lastName, string specialty, string phoneNumber, string email)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Specialty = specialty;
        PhoneNumber = phoneNumber;
        Email = email;
    }
    public Doctor()
    {
    }
    public static Doctor Create(string firstName, string lastName, string specialty, string phoneNumber, string email)
    {
        return new Doctor
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Specialty = specialty,
            PhoneNumber = phoneNumber,
            Email = email
        };
    }
}
public class Nurse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Nurse(Guid id, string firstName, string lastName, string department, string phoneNumber, string email)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Department = department;
        PhoneNumber = phoneNumber;
        Email = email;
    }
    public Nurse()
    {
    }
    public static Nurse Create(string firstName, string lastName, string department, string phoneNumber, string email)
    {
        return new Nurse
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Department = department,
            PhoneNumber = phoneNumber,
            Email = email
        };
    }
}
public class LabTest
{
    public Guid Id { get; set; }
    public string TestName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Cost { get; set; }
    public LabTest(Guid id, string testName, string description, decimal cost)
    {
        Id = id;
        TestName = testName;
        Description = description;
        Cost = cost;
    }
    public LabTest()
    {
    }
    public static LabTest Create(string testName, string description, decimal cost)
    {
        return new LabTest
        {
            Id = Guid.NewGuid(),
            TestName = testName,
            Description = description,
            Cost = cost
        };
    }
}
public class Medication
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Dosage { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public Medication(Guid id, string name, string dosage, string manufacturer)
    {
        Id = id;
        Name = name;
        Dosage = dosage;
        Manufacturer = manufacturer;
    }
    public Medication()
    {
    }
    public static Medication Create(string name, string dosage, string manufacturer)
    {
        return new Medication
        {
            Id = Guid.NewGuid(),
            Name = name,
            Dosage = dosage,
            Manufacturer = manufacturer
        };
    }
}
public class MedicalRecord
{
    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public string Diagnosis { get; set; } = string.Empty;
    public string Treatment { get; set; } = string.Empty;
    public DateTime RecordDate { get; set; }
    public MedicalRecord(Guid id, Guid patientId, string diagnosis, string treatment, DateTime recordDate)
    {
        Id = id;
        PatientId = patientId;
        Diagnosis = diagnosis;
        Treatment = treatment;
        RecordDate = recordDate;
    }
    public MedicalRecord()
    {
    }
    public static MedicalRecord Create(Guid patientId, string diagnosis, string treatment, DateTime recordDate)
    {
        return new MedicalRecord
        {
            Id = Guid.NewGuid(),
            PatientId = patientId,
            Diagnosis = diagnosis,
            Treatment = treatment,
            RecordDate = recordDate
        };
    }
}
public class Appointment
{
    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public Guid DoctorId { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Reason { get; set; } = string.Empty;
    public Appointment(Guid id, Guid patientId, Guid doctorId, DateTime appointmentDate, string reason)
    {
        Id = id;
        PatientId = patientId;
        DoctorId = doctorId;
        AppointmentDate = appointmentDate;
        Reason = reason;
    }
    public Appointment()
    {
    }
    public static Appointment Create(Guid patientId, Guid doctorId, DateTime appointmentDate, string reason)
    {
        return new Appointment
        {
            Id = Guid.NewGuid(),
            PatientId = patientId,
            DoctorId = doctorId,
            AppointmentDate = appointmentDate,
            Reason = reason
        };
    }
}