namespace CarBook.EntityLayer.Concrete
{
    public class CarDetail
    {
        public int CarDetailID { get; set; }
        public string Description { get; set;}
        public DateTime CreatedDate { get; set; }

        public int CarID { get; set; }
        public Car Car { get; set; }

        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}