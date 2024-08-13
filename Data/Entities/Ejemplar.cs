using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Ejemplar
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public int LibroId { get; set; }
        public int EstanteId { get; set; }
        public bool EstaDeBaja { get; set; }
        public string MotivoBaja { get; set; }
        public decimal MontoReferencial { get; set; }
    }
}
