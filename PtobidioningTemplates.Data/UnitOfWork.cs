using ProvisioningTemplates.Data.Repositories;
using ProvisioningTemplates.Interfaces;
using ProvisioningTemplates.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisioningTemplates.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        // Context
        private readonly ProvisioningTemplatesDbContext _context;

        // Repository fields
        private ITestRepository _testRepository;

        public UnitOfWork()
        {
            if (_context == null)
            {
                _context = new ProvisioningTemplatesDbContext();
            }
        }

        // Properties
        public ITestRepository TestRepository
        {
            get
            {
                if (_testRepository == null)
                {
                    _testRepository = new TestRepository(_context);
                }

                return _testRepository;
            }
        }
        
        // Methods
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                throw (e);
            }
        }

        public void Dispose()
        {
            // Dispose(true);
            // GC.SuppressFinalize(this);
        }
    }
}
