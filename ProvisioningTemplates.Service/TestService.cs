using ProvisioningTemplates.Interfaces.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProvisioningTemplates.Domain;
using ProvisioningTemplates.Interfaces;

namespace ProvisioningTemplates.Service
{
    public class TestService : ITestService
    {
        private readonly IUnitOfWork _uow;

        public TestService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<Test> GetAllTests()
        {
            return _uow.TestRepository.FindAllMatching(_ => true);
        }

        public Test GetTestById(int id)
        {
            return _uow.TestRepository.FindById(id);
        }
    }
}
