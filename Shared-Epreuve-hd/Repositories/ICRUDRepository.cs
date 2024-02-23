using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Epreuve_hd.Repositories
{
    public interface ICRUDRepository<TEntity, TId>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TId id);
        TId Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TId id);
    }
}

