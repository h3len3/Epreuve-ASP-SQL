using BLL_Epreuve_hd.Entities;
using BLL_Epreuve_hd.Mappers;
using Shared_Epreuve_hd.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = DAL_Epreuve_hd.Services;

namespace BLL_Epreuve_hd.Services
{
    public class CategoryService : ICategoryRepository<string>
    {
        private readonly DAL.CategoryService _Repository;

        public CategoryService(DAL.CategoryService repository)
        {
            _Repository = repository;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Get()
        {
            return _Repository.Get();
        }

        public string Get(string id)
        {
            throw new NotImplementedException();
        }

        public string Insert(string entity)
        {
            throw new NotImplementedException();
        }

        public void Update(string entity)
        {
            throw new NotImplementedException();
        }
    }
}
