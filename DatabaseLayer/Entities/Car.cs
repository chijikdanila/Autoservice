using System;

namespace DatabaseLayer.Entities
{
    public class Car
    {        
        public int id { get; set; }
        public bool IsTruck { get; set; } = false;
        public string Model { get; set; }
        public string CarType { get; set; }
        public string Manufacturer { get; set; }
        public string CarAssembly { get; set; }
        public string CarNumber { get; set; }
        public int StatusId { get; set; }

        public bool isFullyDescribed()
        {
            if (string.IsNullOrEmpty(Model)) return false;
            if (string.IsNullOrEmpty(CarType)) return false;
            if (string.IsNullOrEmpty(Manufacturer)) return false;
            if (string.IsNullOrEmpty(CarAssembly)) return false;
            if (string.IsNullOrEmpty(CarNumber)) return false;
            return true;
        }

        public override string ToString()
        {
            return $"{Model} {CarNumber}, {Manufacturer}";
        }
    }
}
