namespace CarBook.EntityLayer.Concrete
{
    public class BlogComment
    {
        public int BlogCommentID { get; set; }
        public string FullName { get; set; }
        public int Score { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }

        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}