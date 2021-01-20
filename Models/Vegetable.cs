using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECF_LEGUMOS_CARRIVALE.Models
{

    [Table("Vegetables")]
    public class Vegetable
    {

        [Key]
        public int VegetableId { get; set; }


        [Required]
        [StringLength(50, ErrorMessage = "Le nom du végétale ne peut excéder 50 caractères.")]
        [MaxLength(50)]
        public string Name { get; set; }


        [Required]
        [StringLength(50, ErrorMessage = "Le nom de la variété ne peut excéder 50 caractères.")]
        [MaxLength(50)]
        public string Variety { get; set; }


        [Required]
        [StringLength(20, ErrorMessage = "Le nom de la couleur ne peut excéder 20 caractères.")]
        [MaxLength(20)]
        public string PrimaryColor { get; set; }


        [Required]
        public int LifeTime { get; set; }


        [Required]
        [DefaultValue(1)]
        public int Fresh { get; set; }



    }
}
