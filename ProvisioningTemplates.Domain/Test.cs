using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisioningTemplates.Domain
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Test()
        {

        }

        public Test(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
