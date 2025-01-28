using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Infrastructure.StoredModel.Entities
{
    [Table("recetaAndIngrediente")]
    internal class recetaAndIngrediente
    {
        [Key]
        [Column("recetaAndIngredienteId")]
        public Guid Id { get; set; }

        [Column("recetaId")]
        [Required]
        public Guid receta { get; set; }

        [Column("ingredienteId")]
        [Required]
        public Guid ingrediente { get; set; }
    }
}
