namespace CarBook.EntityLayer.Concrete
{
    public class Team
    {
        public int TeamID { get; set; }
        public string? ImageURL { get; set; }
        public string? Title { get; set; }
        public string? FullName { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
    }
}