using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Infrastructure.StoredModel.Entities
{
    [Table("receta")]
    internal class RecetaStoredModel
    {
        [Key]
        [Column("recetaId")]
        public Guid Id { get; set; }

        [Column("recetaName")]
        [Required]
        public string recetaName { get; set; }
    }
}
