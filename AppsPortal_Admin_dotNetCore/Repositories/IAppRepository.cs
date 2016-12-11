using AppsPortal.Entities.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppsPortal.Admin.dotNetCore.Repositories
{
    public interface IAppRepository
    {
        IEnumerable<Apps> GetAllVersionsByApplication();
        IEnumerable<Apps> GetAllApplications();
        Apps GetApplication(string appTitle);

    }
}