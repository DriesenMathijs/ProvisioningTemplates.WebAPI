using ProvisioningTemplates.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisioningTemplates.Interfaces.ServiceInterfaces
{
    public interface ITestService
    {
        /// <summary>
        /// Gets all tests
        /// </summary>
        /// <returns></returns>
        IEnumerable<Test> GetAllTests();
        /// <summary>
        /// Gets a test by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Test GetTestById(int id);
    }
}
