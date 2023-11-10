namespace CarBook.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}