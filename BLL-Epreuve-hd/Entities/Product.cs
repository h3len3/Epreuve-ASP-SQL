using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Epreuve_hd.Entities
{
    public class Product
    {
        public int Id_Product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Ecoscore EcologicalCriteriaEcoScore { get; set; }
        public string CategoryName { get; set; }
       

        public Product(int id_product, string name, string description, decimal price, Ecoscore ecologicalcriteriaecoscore, string categoryname)
        {
            Id_Product = id_product;
            Name = name;
            Description = description;
            Price = price;
            EcologicalCriteriaEcoScore = ecologicalcriteriaecoscore;
            CategoryName = categoryname;
            
        }

        
    }
}
