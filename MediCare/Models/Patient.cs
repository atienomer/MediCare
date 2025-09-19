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
