namespace CarBook.EntityLayer.Concrete
{
    public class ContactForm
    {
        public int ContactFormID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime ContactDate { get; set; }
    }
}