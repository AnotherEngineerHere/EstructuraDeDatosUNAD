using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolesbinarios
{
    public class ArbolBinario
    {
        public Nodo Raiz { get; private set; }

        public void Insertar(int valor)
        {
            Raiz = InsertarRecursivo(Raiz, valor);
        }

        private Nodo InsertarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
                return new Nodo(valor);

            if (valor < nodo.Valor)
                nodo.Izquierda = InsertarRecursivo(nodo.Izquierda, valor);
            else if (valor > nodo.Valor)
                nodo.Derecha = InsertarRecursivo(nodo.Derecha, valor);

            return nodo;
        }

        public bool Buscar(int valor)
        {
            return BuscarRecursivo(Raiz, valor);
        }

        private bool BuscarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null) return false;
            if (nodo.Valor == valor) return true;

            return valor < nodo.Valor
                ? BuscarRecursivo(nodo.Izquierda, valor)
                : BuscarRecursivo(nodo.Derecha, valor);
        }

        public List<int> ObtenerPreorden()
        {
            List<int> recorrido = new List<int>();
            Preorden(Raiz, recorrido);
            return recorrido;
        }

        private void Preorden(Nodo nodo, List<int> lista)
        {
            if (nodo == null) return;
            lista.Add(nodo.Valor);
            Preorden(nodo.Izquierda, lista);
            Preorden(nodo.Derecha, lista);
        }

        public List<int> ObtenerInorden()
        {
            List<int> recorrido = new List<int>();
            Inorden(Raiz, recorrido);
            return recorrido;
        }

        private void Inorden(Nodo nodo, List<int> lista)
        {
            if (nodo == null) return;
            Inorden(nodo.Izquierda, lista);
            lista.Add(nodo.Valor);
            Inorden(nodo.Derecha, lista);
        }

        public List<int> ObtenerPosorden()
        {
            List<int> recorrido = new List<int>();
            Posorden(Raiz, recorrido);
            return recorrido;
        }

        private void Posorden(Nodo nodo, List<int> lista)
        {
            if (nodo == null) return;
            Posorden(nodo.Izquierda, lista);
            Posorden(nodo.Derecha, lista);
            lista.Add(nodo.Valor);
        }
    }
}
