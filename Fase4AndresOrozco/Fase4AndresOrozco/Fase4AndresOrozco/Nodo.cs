using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolesbinarios
{
    public class Nodo
    {
        // Valor del nodo
        public int Valor { get; set; }

        // Punteros a los nodos izquierdo y derecho
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }

        // Constructor que inicializa el nodo con un valor
        public Nodo(int valor)
        {
            Valor = valor;
            Izquierda = null;
            Derecha = null;
        }
    }
}
