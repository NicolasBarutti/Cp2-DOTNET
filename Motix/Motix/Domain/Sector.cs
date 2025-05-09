
namespace Motix.API.Domain
{
    public class Sector
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YardId { get; set; }
        public Yard Yard { get; set; }

    
        public Sector(string name, int yardId)
        {
            Name = name;
            YardId = yardId;
        }
    }
}
