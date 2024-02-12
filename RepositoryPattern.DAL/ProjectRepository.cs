using RepositoryPattern.BLL;
using RepositoryPattern.MODEL;

namespace RepositoryPattern.DAL
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationContext context) : base(context)
        {
        }

    }
}
