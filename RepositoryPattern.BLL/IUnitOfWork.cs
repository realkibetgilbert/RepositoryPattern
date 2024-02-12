using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.BLL
{
    public interface IUnitOfWork:IDisposable
    {
        IDeveloperRepository Developers { get; }
        IProjectRepository Projects { get; }

        int Complete();

    }
}
