
namespace Motix.API.Domain
{
    public class Movement
    {
        public int Id { get; set; }
        public int MotorcycleId { get; set; }
        public Motorcycle Motorcycle { get; set; }
        public int OriginSectorId { get; set; }
        public Sector OriginSector { get; set; }
        public int DestinationSectorId { get; set; }
        public Sector DestinationSector { get; set; }
        public DateTime MovementDate { get; set; }

        public Movement(int motorcycleId, int originSectorId, int destinationSectorId, DateTime movementDate)
        {
            MotorcycleId = motorcycleId;
            OriginSectorId = originSectorId;
            DestinationSectorId = destinationSectorId;
            MovementDate = movementDate;
        }
    }
}
