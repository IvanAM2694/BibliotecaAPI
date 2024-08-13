using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Prestamo
    {
        public int Id { get; set; }
        public string CodigoEjemplar { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public bool Devuelto {  get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int DiasRetraso { get; set; }
    }
}
