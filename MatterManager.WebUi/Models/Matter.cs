using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MatterManager.WebUi.Models
{
    public class Matter
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "Matter Name")]
        [StringLength(255, MinimumLength = 1)]
        public string Name { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "Network Matter Number")]
        [StringLength(255, MinimumLength = 1)]
        public string NetworkMatterNumber { get; set; }

        [Required]
        [Display(Name = "Network Workarea")]
        [StringLength(255, MinimumLength = 1)]
        public string Workarea { get; set; }

        [Required]
        [Display(Name = "Responsible Professional")]
        [StringLength(255, MinimumLength = 1)]
        public string ResponsibleProfessional { get; set; }
    }
}