namespace lab1projekt.models
{
    public class MenuItem
    {
        public int Id { get; set; }

        public string Emertimi { get; set; } = "";

        public string Pershkrimi { get; set; } = "";

        public decimal Cmimi { get; set; }

        public int CategoryId { get; set; }

        public MenuCategory Category { get; set; }
    }
}