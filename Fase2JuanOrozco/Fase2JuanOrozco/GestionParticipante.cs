using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2JuanOrozco
{
    public class GestionParticipantes
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Tecnica { get; set; }
        public int NumeroClases { get; set; }
        public decimal CostoPorClase { get; set; }
        public string Genero { get; set; }

        public GestionParticipantes(int id, string nombre, string tecnica, int numeroClases, decimal costoPorClase, string genero)
        {
            ID = id;
            Nombre = nombre;
            Tecnica = tecnica;
            NumeroClases = numeroClases;
            CostoPorClase = costoPorClase;
            Genero = genero;
        }

        public decimal CalcularCostoTotal()
        {
            return NumeroClases * CostoPorClase;
        }
    }
}
