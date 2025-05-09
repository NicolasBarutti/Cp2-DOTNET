
namespace Motix.API.Domain
{
    public class Yard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Sector> Sectors { get; set; }

        
        public Yard(string name, string location)
        {
            Name = name;
            Location = location;
            Sectors = new List<Sector>();
        }
    }
}

