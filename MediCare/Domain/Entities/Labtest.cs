using MediCare.Domain.Shared;

namespace MediCare.Domain.Entities
{
    public class LabTest : BaseEntity
    {
        public string TestName { get; set; } = string.Empty;
        public int StaffId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Cost { get; set; }

        // List of nurses associated with this lab test
        public ICollection<Nurse> Nurses { get; set; } = new List<Nurse>();

        // Constructor with parameters
        public LabTest(string testName, string description, decimal cost)
        {
            TestName = testName;
            Description = description;
            Cost = cost;
        }

        // Default constructor
        public LabTest()
        {
        }
    }
}

