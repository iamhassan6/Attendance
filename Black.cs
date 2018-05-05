using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstP.DATA
{
    [Table("Blacklist")]
    public partial class Black
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int eid { get; set; }
        [StringLength(100)]
        public string nic { get; set; }
        [Column(TypeName="text")]
        public string remarks { get; set; }
        public DateTime dated { get; set; }
    }
}
