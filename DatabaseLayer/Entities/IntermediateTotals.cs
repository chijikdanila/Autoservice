namespace DatabaseLayer.Entities
{
    public class IntermediateTotals
    {
        public int id { get; set; }
        public int CarId { get; set; }
        public int ServiceTypeId { get; set; }
        public string DateOfServise { get; set; }

        public bool isFullyDescribed()
        {
            if (string.IsNullOrEmpty(DateOfServise)) return false;
            return true;
        }
    }
}
