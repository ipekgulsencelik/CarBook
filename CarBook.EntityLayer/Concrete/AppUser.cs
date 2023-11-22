using Microsoft.AspNetCore.Identity;

namespace CarBook.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }
        public string? ImageURL { get; set; }

        public List<CarDetail> CarDetails { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
