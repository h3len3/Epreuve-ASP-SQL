
using ASP_Epreuve_hd.Models;
using ASP_Epreuve_hd.Models.Product;
using BLL_Epreuve_hd.Entities;

using System.Xml.Linq;


namespace ASP_Epreuve_hd.Handlers
{
    public static class Mapper
    {
        public static ProductListItemViewModel ToListItem(this Product entity)
        {
            if (entity is null) return null;
            return new ProductListItemViewModel
            {
                Id_Product = entity.Id_Product,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                EcologicalCriteriaEcoScore = entity.EcologicalCriteriaEcoScore,
                CategoryName = entity.CategoryName

            };
        }

        public static ProductDetailsViewModel ToDetails(this Product entity)
        {
            if (entity is null) return null;
            return new ProductDetailsViewModel
            {
                Id_Product = entity.Id_Product,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                EcologicalCriteriaEcoScore = entity.EcologicalCriteriaEcoScore,
                CategoryName = entity.CategoryName
            };
        }

        public static Product ToBLL(this ProductCreateForm entity)
        {
            if (entity is null) return null;
            return new Product(
                0,
                entity.Name,
                entity.Description,
                entity.Price,
                entity.EcologicalCriteriaEcoScore,
                entity.CategoryName);
        }

        public static ProductEditForm ToEditForm(this Product entity)
        {
            if (entity is null) return null;
            return new ProductEditForm()
            {
                Id_Product = entity.Id_Product,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                EcologicalCriteriaEcoScore = entity.EcologicalCriteriaEcoScore,
                CategoryName = entity.CategoryName
            };
        }

        public static Product ToBLL(this ProductEditForm entity)
        {
            if (entity is null) return null;
            return new Product(
                entity.Id_Product,
                entity.Name,
                entity.Description,
                entity.Price,
                entity.EcologicalCriteriaEcoScore,
                entity.CategoryName);
        }

        public static ProductDeleteViewModel Delete(this Product entity)
        {
            if (entity is null) return null;
            return new ProductDeleteViewModel()
            {
                Id_Product = entity.Id_Product,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                EcologicalCriteriaEcoScore = entity.EcologicalCriteriaEcoScore,
                CategoryName = entity.CategoryName
            };
        }      
    }
}


