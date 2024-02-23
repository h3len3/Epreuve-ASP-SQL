using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL_Epreuve_hd.Entities
{
    public class Product
    {
        public int Id_Product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string EcologicalCriteriaEcoScore { get; set; }
        public string CategoryName { get; set; }
        
    }
}



