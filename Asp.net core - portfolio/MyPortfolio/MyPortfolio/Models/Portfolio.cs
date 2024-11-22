namespace MyPortfolio.Models
{
    public class Portfolio
    {
        public long Id { get; set; }
        public string category { get; set; }
        public string date { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        //public string description { get; set; }
    }
    public class Contact
    {
        //public string key { get; set; }
        //public string value { get; set; }

        public string location { get; set; }
        public string email { get; set; }
        public long phone { get; set; }
    }

    public class CombinedViewModel
    {
        public List<Portfolio> Portfolios { get; set; }
        public Contact Contact { get; set; }
    }
}