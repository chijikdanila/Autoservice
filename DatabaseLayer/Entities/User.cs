namespace DatabaseLayer.Entities
{
    public class User
    {
        public int id { get; set; }
        public string NickName { get; set; }
        public string Pass { get; set; }
        public bool User_Type { get; set; }

        public bool isFullyDescribed()
        {
            if (string.IsNullOrEmpty(NickName)) return false;
            if (string.IsNullOrEmpty(Pass)) return false;
            return true;
        }

        public override string ToString()
        {
            return NickName;
        }
    }
}
