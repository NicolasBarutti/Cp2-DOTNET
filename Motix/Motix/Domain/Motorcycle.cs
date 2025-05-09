
namespace Motix.API.Domain
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string? LicensePlate { get; set; }
        public string? Chassis { get; set; }
        public int SectorId { get; set; }
        public Sector Sector { get; set; }
        public DateTime EntryDate { get; set; }
        public bool IsActive { get; set; }

        public Motorcycle(string licensePlate, string chassis, int sectorId, DateTime entryDate, bool isActive)
        {
            LicensePlate = licensePlate;
            Chassis = chassis;
            SectorId = sectorId;
            EntryDate = entryDate;
            IsActive = isActive;
        }

      
        public Motorcycle() { }

       
        public bool ValidateMotorcycle()
        {
            if (string.IsNullOrEmpty(LicensePlate) || string.IsNullOrEmpty(Chassis))
                return false;

            return true;
        }
    }
}
