using RepositoryPattern.BLL;
using RepositoryPattern.MODEL;

namespace RepositoryPattern.DAL
{
    public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        private readonly ApplicationContext _context;

        public DeveloperRepository(ApplicationContext context):base(context) 
        {
            _context = context;
        }
        public IEnumerable<Developer> GetPopularDevelopers(int count)
        {
            return _context.Developers.OrderByDescending(d => d.Followers).Take(count).ToList();
        }
    }
}
