namespace MatterManager.Persistence
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Matter")]
    public partial class Matter
    {
        [Key]
        public int matter_id { get; set; }

        [Required]
        [StringLength(255)]
        public string matter_name { get; set; }

        [Required]
        [StringLength(255)]
        public string network_matter_number { get; set; }

        [Required]
        [StringLength(255)]
        public string network_work_area { get; set; }

        [Required]
        [StringLength(255)]
        public string responsible_professional { get; set; }
    }
}
