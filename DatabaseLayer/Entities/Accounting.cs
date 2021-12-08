using DatabaseLayer.Entities.Enums;

namespace DatabaseLayer.Entities
{
    public class Accounting
    {
        public int id { get; set; }
        public int CarId { get; set; }
        public int Milleage { get; set; } = -1; // Минус 1 чтобы типо потом проверить, изменял ли ты (т.к. теоретически может быть километраж 0)
        public Status EngineStatus { get; set; } = 0;
        public Status ChassisStatus { get; set; } = 0;
        public Status CarcassStatus { get; set; } = 0;

        public bool isFullyDescribed()
        {
            if (Milleage == -1) return false;
            if (EngineStatus == 0) return false;
            if (ChassisStatus == 0) return false;
            if (EngineStatus == 0) return false;
            return true;
        }
    }
}
