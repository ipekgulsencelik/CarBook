namespace CarBook.EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; }
        public DateTime ContactDate { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public bool IsImportant { get; set; }
    }
}