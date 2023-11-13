using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.EntityFramework
{
	public class EFTestimonialDAL : GenericRepository<Testimonial>, ITestimonialDAL
	{
	}
}