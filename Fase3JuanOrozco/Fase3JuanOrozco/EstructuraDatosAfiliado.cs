using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3JuanOrozco
{
    public class EstructuraDatosAfiliado
    {
        public string TipoId { get; set; }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public decimal Salario { get; set; }
        public int Estrato { get; set; }
        public bool AfiliadoSISBEN { get; set; }
        public decimal Subsidio { get; set; }
        public DateTime FechaAfiliacion { get; set; }
    }
}
