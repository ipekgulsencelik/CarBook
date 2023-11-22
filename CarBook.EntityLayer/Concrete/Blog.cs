namespace CarBook.EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string CoverImageURL { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public bool IsHome { get; set; }
        public bool IsDeleted { get; set; }

        public int AuthorID { get; set; }
        public Author Author { get; set; }
        
        public int BlogCategoryID { get; set; }
        public BlogCategory BlogCategory { get; set; }
        
        public List<TagCloud> TagClouds { get; set; }
        public List<BlogComment> BlogComments { get; set; }
    }
}