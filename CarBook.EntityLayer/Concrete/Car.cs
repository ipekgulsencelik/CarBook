namespace CarBook.EntityLayer.Concrete
{
    public class Car
    {
        public int CarID { get; set; }
        public string Model { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        
        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        public string ImageURL { get; set; }
        public string GearType { get; set; }
        public int Km { get; set; }
        public byte PersonCount { get; set; }
        public int Year { get; set; }
        public bool IsActive { get; set; }

        public int StatusID { get; set; }
        public Status Status { get; set; }
        
        public List<Price> Prices { get; set; }
        public List<CarDetail> CarDetails { get; set; }
        public List<Comment> Comments { get; set; }
    }
}