using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Infrastructure.StoredModel.Entities
{

    [Table("paquete")]
    internal class PaqueteStoredModel
    {
        [Key]
        [Column("paqueteId")]
        public Guid Id { get; set; }

        [Column("paqueteName")]
        [Required]
        public string Paquetename { get; set; }
    }

}
