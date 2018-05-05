namespace FirstP.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Atten")]
    public partial class Atten
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int eid { get; set; }

        [StringLength(100)]
        public string enic { get; set; }

        [StringLength(1)]
        public string shft { get; set; }

        public decimal? hrs { get; set; }

        [StringLength(100)]
        public string edep { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Dte { get; set; }

        public TimeSpan? intime { get; set; }

        [Key]
        [Column(Order = 1)]
        public TimeSpan outtime { get; set; }

        public decimal overtime { get; set; }
    }
}
