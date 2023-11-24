using System.Text.Json.Serialization;

namespace CarBook.EntityLayer.Concrete
{
    public class Car
    {
        public int CarID { get; set; }
        public string Model { get; set; }

        public int CategoryID { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
        
        public int BrandID { get; set; }
        [JsonIgnore]
        public Brand Brand { get; set; }

        public string ImageURL { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public byte Door { get; set; }
        public byte PersonCount { get; set; }
        public int Year { get; set; }
        public string GasType { get; set; }
        public decimal RentPrice { get; set; }
        public bool IsActive { get; set; }

        public int StatusID { get; set; }
        [JsonIgnore]
        public Status Status { get; set; }
        
        public List<Price> Prices { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
        public List<CarDetail> CarDetails { get; set; }
        public List<Comment> Comments { get; set; }
    }
}