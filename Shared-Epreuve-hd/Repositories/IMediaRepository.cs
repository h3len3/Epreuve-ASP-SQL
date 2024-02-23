using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Epreuve_hd.Repositories
{
    public interface IMediaRepository<TEntity> : ICRUDRepository<TEntity, int>
    {
    }
}


