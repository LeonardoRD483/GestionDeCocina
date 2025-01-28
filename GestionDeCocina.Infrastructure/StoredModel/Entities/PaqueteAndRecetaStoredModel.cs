using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Infrastructure.StoredModel.Entities
{


    [Table("paqueteAndReceta")]
    internal class PaqueteAndRecetaStoredModel
    {
        [Key]
        [Column("paqueteAndRecetaId")]
        public Guid Id { get; set; }

        [Column("paqueteId")]
        [Required]
        public Guid paquete { get; set; }

        [Column("recetaId")]
        [Required]
        public Guid receta { get; set; }
    }
}
