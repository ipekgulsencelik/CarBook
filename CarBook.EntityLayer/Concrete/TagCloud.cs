namespace CarBook.EntityLayer.Concrete
{
    public class TagCloud
    {
        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }

        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}