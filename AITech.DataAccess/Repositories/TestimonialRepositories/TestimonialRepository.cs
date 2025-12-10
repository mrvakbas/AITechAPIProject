using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : GenericRepository<Testimonial>, ITestimonialRepository
    {
        public TestimonialRepository(AppDbContext _context) : base(_context)
        {
        }
    }
}
