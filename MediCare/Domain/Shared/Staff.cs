namespace MediCare.Domain.Shared
{
    public class Staff
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public int NationalId { get; set; }
        public int SpecialtyId { get; set; }
        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;
        public int DepartmentId { get; set; }

    }
}
