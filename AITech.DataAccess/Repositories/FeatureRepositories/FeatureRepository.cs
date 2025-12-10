using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.FeatureRepositories
{
    public class FeatureRepository : GenericRepository<Feature>, IFeatureRepository
    {
        public FeatureRepository(AppDbContext _context) : base(_context)
        {
        }
    }
}
