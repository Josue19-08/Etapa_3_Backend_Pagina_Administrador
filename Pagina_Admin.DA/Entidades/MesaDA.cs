using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagina_Admin.DA.Entidades
{
    [Table("Mesa")]
    public class MesaDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int NumMesa { get; set; }

        [ForeignKey("Restaurante")]
        public int RestauranteId { get; set; }
    }


}
