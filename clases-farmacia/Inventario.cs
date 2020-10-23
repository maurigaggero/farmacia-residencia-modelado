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
        public int Id { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [ForeignKey("Id")]
        public Medicamento Medicamento { get; set; }
    }
}
