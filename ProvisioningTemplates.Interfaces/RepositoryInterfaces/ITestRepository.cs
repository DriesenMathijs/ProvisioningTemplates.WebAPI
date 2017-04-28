using ProvisioningTemplates.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisioningTemplates.Interfaces.RepositoryInterfaces
{
    public interface ITestRepository : IBaseRepository<Test, int>
    {
    }
}
