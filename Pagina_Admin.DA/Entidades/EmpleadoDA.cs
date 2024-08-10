using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagina_Admin.DA.Entidades
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Empleado")]
    public class EmpleadoDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Restaurante")]
        public int RestauranteId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(20)]
        public string Cedula { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(100)]
        public string Contrasena { get; set; }

    }

}
