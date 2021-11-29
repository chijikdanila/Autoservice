namespace Autoservice.Entities
{
    public class CarStatus
    {
        public int id { get; set; }
        public string Condition { get; set; }

        public bool isFullyDescribed()
        {
            if (string.IsNullOrEmpty(Condition)) return false;
            return true;
        }
    }
}
