namespace CarBook.DTOLayer.DTOs.AboutDTOs
{
    public class AboutDTO
    {
        public int AboutID { get; set; }
        public string? ImageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? SubDescription { get; set; }
        public bool Status { get; set; }
    }
}