using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BLL_Epreuve_hd.Entities;

namespace ASP_Epreuve_hd.Models
{
    public class ProductEditForm
    {
        [HiddenInput]
        [Required(ErrorMessage = "L'identifiant du produit est obligatoire.")]
        public int Id_Product { get; set; }

        [DisplayName("Nom")]
        [Required(ErrorMessage = "Le  nom du produit  est obligatoire.")] 
        [MaxLength(64, ErrorMessage = "Le titre du film doit être composé de maximum 64 caractères.")]
        public string Name { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "La description du produit  est obligatoire.")]
        public string Description { get; set; }
        [DisplayName("Prix (en €)")]
        [Required(ErrorMessage = "Le  prix du produit  est obligatoire.")]
        public decimal Price { get; set; }
        [DisplayName("Eco score")]
        [Required(ErrorMessage = "L'écoscore du produit  est obligatoire.")]
        public Ecoscore EcologicalCriteriaEcoScore { get; set; }

        [DisplayName("Catégorie")]
        [Required(ErrorMessage = "La catégorie du produit  est obligatoire.")]
        public string CategoryName { get; set; }
    }
}

