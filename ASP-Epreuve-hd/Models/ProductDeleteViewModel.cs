using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BLL_Epreuve_hd.Entities;

namespace ASP_Epreuve_hd.Models
{
    public class ProductDeleteViewModel
    {
        [HiddenInput]
        [Required]

        public int Id_Product { get; set; }

        [DisplayName("Nom")]
        public string Name { get; set; }
        [DisplayName("Description")]

        public string Description { get; set; }
        [DisplayName("Prix (en €)")]
        public decimal Price { get; set; }
        [DisplayName("Eco score")]
        public Ecoscore EcologicalCriteriaEcoScore { get; set; }

        [DisplayName("Catégorie")]
        public string CategoryName { get; set; }
    }
}

