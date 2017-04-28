using ProvisioningTemplates.Domain;
using ProvisioningTemplates.Interfaces.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ProvisioningTemplates.WebAPI.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        /// <summary>
        /// Get a test by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id:int}", Name ="GetTestById"), AllowAnonymous]
        public IHttpActionResult Get(int id)
        {
            var result = _testService.GetTestById(id);

            if (result == null) return NotFound();
            
            return Ok(result);
        }

        /// <summary>
        /// Get all the events
        /// </summary>
        /// <returns></returns>
        [Route, AllowAnonymous]
        public IHttpActionResult GetAll()
        {
            List<Test> tests = null;

            tests = _testService.GetAllTests().ToList();

            if (tests == null)
            {
                return NotFound();
            }
            
            return Ok(tests);
        }
    }
}