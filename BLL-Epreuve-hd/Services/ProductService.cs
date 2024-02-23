using BLL_Epreuve_hd.Entities;
using BLL_Epreuve_hd.Mappers;
using DAL_Epreuve_hd.Entities;
using Shared_Epreuve_hd.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using DAL = DAL_Epreuve_hd.Entities;
using Product =BLL_Epreuve_hd.Entities.Product;

namespace BLL_Epreuve_hd.Services
{
    public class ProductService : IProductRepository<Product>
    {
        private readonly IProductRepository<DAL.Product> _productRepository;
        

        public ProductService(IProductRepository<DAL.Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> Get()
        {
            return _productRepository.Get().Select(d => d.ToBLL());
        }

        public Product Get(int id)
        {
            return _productRepository.Get(id).ToBLL();
        }

        public int Insert(Product entity)
        {
             return _productRepository.Insert(entity.ToDAL());
            
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity.ToDAL());
        }
   
        public IEnumerable<Product> GetByCategory(string category)
        {
           
            return _productRepository.GetByCategory(category).Select(d => d.ToBLL());
        }
        
    }
  
}
