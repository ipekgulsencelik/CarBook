namespace CarBook.EntityLayer.Concrete
{
    public class Message
    {
        public int MessageID { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
        public bool IsDraft { get; set; }
        public bool Trash { get; set; }
        public bool IsRead { get; set; }
        public bool IsImportant { get; set; }
        public bool IsSpam { get; set; }
    }
}