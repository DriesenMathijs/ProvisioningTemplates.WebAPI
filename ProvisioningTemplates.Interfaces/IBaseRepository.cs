using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProvisioningTemplates.Interfaces
{
    public interface IBaseRepository<TEntity, TId>
    {
        TEntity FindById(TId id);
        IEnumerable<TEntity> FindAllMatching(Expression<Func<TEntity, bool>> query);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
