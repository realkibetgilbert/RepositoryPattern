using RepositoryPattern.MODEL;

namespace RepositoryPattern.BLL
{
    public interface IDeveloperRepository:IGenericRepository<Developer>
    {
        IEnumerable<Developer> GetPopularDevelopers(int count);
    }
}
