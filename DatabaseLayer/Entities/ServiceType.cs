namespace DatabaseLayer.Entities
{
    public class ServiceType
    {
        public int id { get; set; }
        public string TypeService { get; set; }
        public string TimePeriod { get; set; }

        public bool isFullyDescribed()
        {
            if (string.IsNullOrEmpty(TypeService)) return false;
            if (string.IsNullOrEmpty(TimePeriod)) return false;
            return true;
        }
    }
}
