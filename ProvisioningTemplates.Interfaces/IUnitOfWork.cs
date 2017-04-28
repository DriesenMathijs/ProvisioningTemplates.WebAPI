using ProvisioningTemplates.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisioningTemplates.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();

        ITestRepository TestRepository { get; }
    }
}
