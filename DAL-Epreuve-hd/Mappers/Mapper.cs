using DAL_Epreuve_hd.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace DAL_Epreuve_hd.Mappers
{
    internal static class Mapper
    {
        public static Product ToProduct(this IDataRecord record)
        {
            if (record is null) return null;
            return new Product()
            {
               Id_Product = (int)record["Id_Product"],
               Name = (string)record["Name"],
               Description = (string)record["Description"], 
               Price = (decimal)record["Price"],
               EcologicalCriteriaEcoScore = (string)record["EcologicalCriteriaEcoScore"],
               CategoryName = (string)record["CategoryName"]
            };
        }
    }
}


