namespace MediCare.Domain.Shared
{
    public interface IStaff 
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int NationalId { get; set; }
        int SpecialtyId { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        int DepartmentId { get; set; }
    }
}
