using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_Epreuve_hd.Repositories
{
    public  interface ICategoryRepository<TEntity> : ICRUDRepository<TEntity, string>
    {
    }
  
}
