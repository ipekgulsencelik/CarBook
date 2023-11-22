namespace CarBook.EntityLayer.Concrete
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}