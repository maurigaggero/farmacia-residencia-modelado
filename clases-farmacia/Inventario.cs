using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_farmacia
{
    public class Inventario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public long Codigo { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required] 
        public DateTime Fecha_Vencimiento { get; set; }
        [ForeignKey("Codigo")]
        public Medicamento Medicamento { get; set; }
    }
}
