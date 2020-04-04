using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyMedsManager.Models
{
    public class Medication
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Medicine { get; set; }
        [Required]
        [Display(Name = "Medicine Quantity")]
        public int MedQuantity { get; set; }
        [Required]
        public string Dosage { get; set; }
        public string Notes { get; set; }
    }
}
