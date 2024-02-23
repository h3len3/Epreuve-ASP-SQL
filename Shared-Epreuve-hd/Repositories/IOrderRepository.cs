using Shared_Epreuve_hd.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Epreuve_hd.Repositories
{
    public interface IOrderRepository<TEntity> : ICRUDRepository<TEntity, int>
    {
    }
}


