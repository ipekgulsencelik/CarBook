namespace CarBook.EntityLayer.Concrete
{
    public class Status
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public List<Car> Cars { get; set; }
    }
}
