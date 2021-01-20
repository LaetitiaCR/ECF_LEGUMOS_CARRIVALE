using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECF_LEGUMOS_CARRIVALE.Models
{
    [Table("Sales")]
    public class Sale
    {

        [Key]
        public int SaleId { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SaleDate { get; set; }



        [Required]
        public int SaleWeight { get; set; }


        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal SaleUnitPrice { get; set; }


        [Required]
        [DefaultValue(1)]
        public int SaleActive { get; set; }





        [Required]
        public int VegetableId { get; set; }


    }
















}
