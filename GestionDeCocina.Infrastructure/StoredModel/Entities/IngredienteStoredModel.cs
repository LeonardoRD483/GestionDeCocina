using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Infrastructure.StoredModel.Entities
{
    [Table("ingrediente")]
    internal class IngredienteStoredModel
    {
        [Key]
        [Column("ingredienteId")]
        public Guid Id { get; set; }

        [Column("ingredienteName")]
        [Required]
        public string IngredienteName { get; set; }
    }
}
