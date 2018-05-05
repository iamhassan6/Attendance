namespace FirstP.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int eid { get; set; }

        [Required]
        [StringLength(100)]
        public string ename { get; set; }

        [StringLength(100)]
        public string efname { get; set; }

        public int empdep { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string empnic { get; set; }

        public decimal PHS { get; set; }
        public int bl { get; set; }
    }
}
