using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagina_Admin.DA.Entidades
{
    [Table("Menu")]
    public class MenuDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string NombreArchivo { get; set; }

        [Required]
        public byte[] Contenido { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoMime { get; set; }

        // Mantener solo el RestauranteId sin la propiedad de navegación
        public int RestauranteId { get; set; }
    }

}
