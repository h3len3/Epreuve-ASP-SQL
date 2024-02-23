using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BLL_Epreuve_hd.Entities;

namespace ASP_Epreuve_hd.Models.Product
{
    public class ProductCreateForm
    {
        [DisplayName("Nom")]
        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [MaxLength(64, ErrorMessage = "Le nom ne peut dépasser 64 caractères.")]
  
        public string Name { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "La description est obligatoire.")]
       
        public string Description{ get; set; }
        [DisplayName("Prix (en €)")]
        [Required(ErrorMessage = "Le prix est obligatoire.")]
        
        public decimal Price { get; set; }
        [DisplayName("Eco score")]
        [Required(ErrorMessage = "Un éco store doit être attribué.")]
        //public string EcologicalCriteriaEcoScore { get; set; }
        public Ecoscore EcologicalCriteriaEcoScore { get; set; }

        [DisplayName("Catégorie")]
        [Required(ErrorMessage = "La catégorie est obligatoire.")]

        public string CategoryName { get; set; }


    }
}


