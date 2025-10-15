using MediCare.Domain.Shared;

namespace MediCare.Domain.Entities
{
    public class Labtest : BaseEntity
    {
        public string TestName { get; set; } 
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public ICollection<Nurse> Nurse { get; set; } = new List<Nurse>();//list of nurse associated with the labtest
        public Labtest(string testName, string description, decimal cost)
        {
            TestName = testName;
            Description = description;
            Cost = cost;
        }
   
        public Labtest() 
        {
            { }
        }
        
        

    }
}

