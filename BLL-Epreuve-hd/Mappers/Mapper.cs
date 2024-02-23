using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = DAL_Epreuve_hd.Entities;
using BLL = BLL_Epreuve_hd.Entities;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Xml.Linq;
using BLL_Epreuve_hd.Entities;

namespace BLL_Epreuve_hd.Mappers
{
    internal static class Mapper
    {
        #region Product
        public static BLL.Product ToBLL(this DAL.Product entity)
        {
            if (entity is null) return null;
            return new BLL.Product(
                entity.Id_Product,
                entity.Name,
                entity.Description,
                entity.Price,
                Enum.Parse<Ecoscore>(entity.EcologicalCriteriaEcoScore),
                entity.CategoryName);
        }

        public static DAL.Product ToDAL(this BLL.Product entity)
        {
            if (entity is null) return null;
            return new DAL.Product()
            {
                Id_Product = entity.Id_Product,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                EcologicalCriteriaEcoScore = entity.EcologicalCriteriaEcoScore.ToString(),
                CategoryName = entity.CategoryName
            };
        }
        #endregion
       
    }
}



