namespace FirstP.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Depart")]
    public partial class Depart
    {
        [Key]
        public int depid { get; set; }

        [Required]
        [StringLength(100)]
        public string depname { get; set; }
    }
}
