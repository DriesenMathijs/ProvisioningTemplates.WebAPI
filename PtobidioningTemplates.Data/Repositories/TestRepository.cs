using ProvisioningTemplates.Domain;
using ProvisioningTemplates.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProvisioningTemplates.Data.Repositories
{
    public class TestRepository : ITestRepository
    {
        private ProvisioningTemplatesDbContext _context;

        public TestRepository(ProvisioningTemplatesDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Test> FindAllMatching(Expression<Func<Test, bool>> query)
        {
            //return _context.Test
            //    .Where(query);

            List<Test> dummyData = new List<Test>()
            {
                new Test() { Id = 1, Name = "Test1" },
                new Test() { Id = 2, Name = "Test2" }
            };

            IEnumerable<Test> returnObj = dummyData;

            return returnObj;
        }

        public Test FindById(int id)
        {
            // return _context.Test.FirstOrDefault(_ => _.Id == id);
            return new Test() { Id = 1, Name = "TestObject" };
        }

        public void Insert(Test entity)
        {
            // _context.Test.Add(entity);
        }

        public void Update(Test entity)
        {
            // Remove next line & uncomment the one after - just for build purpose
            var newEnt = "";
            // var newEnt = _context.Test.Find(entity.Id);

            if (newEnt != null)
            {
                _context.Entry(newEnt).CurrentValues.SetValues(entity);
            }
        }

        public void Delete(Test entity)
        {
            // _context.Test.Remove(entity);
        }
    }
}
