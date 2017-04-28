using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisioningTemplates.Data
{
    public class ProvisioningTemplatesDbContext : DbContext
    {
        // Dbset Properties

        public ProvisioningTemplatesDbContext() : base("ProvisioningTemplateDbConnString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            // Db seeder
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProvisioningTemplatesDbContext>());
        }
    }
}
