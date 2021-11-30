namespace DatabaseLayer.Entities
{
    public class Accounting
    {
        public int id { get; set; }
        public int CarId { get; set; }
        public int Milleage { get; set; } = -1; // Минус 1 чтобы типо потом проверить, изменял ли ты (т.к. теоретически может быть километраж 0)
        public int Comissioning { get; set; } = -1;
        public int Decomissioning { get; set; } = -1;
        public string EngineStatus { get; set; }
        public string ChassisStatus { get; set; }
        public string CarcassStatus { get; set; }

        public bool isFullyDescribed()
        {
            if (Milleage == -1) return false;
            if (Comissioning == -1) return false;
            if (Decomissioning == -1) return false;
            if (string.IsNullOrEmpty(EngineStatus)) return false;
            if (string.IsNullOrEmpty(ChassisStatus)) return false;
            if (string.IsNullOrEmpty(CarcassStatus)) return false;
            return true;
        }
    }
}
