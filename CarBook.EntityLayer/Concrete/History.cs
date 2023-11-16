namespace CarBook.EntityLayer.Concrete
{
    public class History
    {
        public int HistoryID { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SubDescription { get; set; }
        public bool Status { get; set; }
    }
}