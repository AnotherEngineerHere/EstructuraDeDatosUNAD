using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// desarrollado por Juan Andres Orozco Nuñez
// Curso estructura de datos
// 301305A_2031
// Tutor  FIDIAS RAFAEL BARROS MONTES

namespace arbolesbinarios
{
    public partial class Form1 : Form
    {
        // Nodo raíz del árbol binario
        private Nodo raiz = null;

        // Constructor principal del formulario
        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes visuales del formulario
        }

        // Evento cuando el formulario se carga por primera vez
        private void Form1_Load(object sender, EventArgs e)
        {
            // No se requiere lógica al cargar
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            // Puedes agregar aquí la lógica para manejar el cambio de texto
        }
        // Evento que ocurre cuando el botón "Agregar" es presionado
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verifica si el texto es un número entero válido
            if (int.TryParse(txtValor.Text, out int numero))
            {
                // Inserta el valor en el árbol
                raiz = InsertarNodo(raiz, numero);

                // Mensaje de confirmación
                MessageBox.Show($"Nodo {numero} agregado correctamente.");

                // Limpia el texto ingresado
                txtValor.Clear();

                // Actualiza los paneles visuales
                pnlArbol.Invalidate();
                pnlPreorden.Invalidate();
                pnlInorden.Invalidate();
                pnlPosorden.Invalidate();
            }
            else
            {
                // Muestra mensaje si no es un número válido
                MessageBox.Show("Por favor ingrese un número válido.");
            }
        }

        // Evento del botón "Buscar"
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verifica si el texto es un número
            if (int.TryParse(txtValor.Text, out int numero))
            {
                // Busca el nodo
                bool encontrado = BuscarNodo(raiz, numero);

                // Muestra si fue encontrado o no
                string mensaje = encontrado
                    ? $"El nodo {numero} SÍ se encuentra en el árbol."
                    : $"El nodo {numero} NO se encuentra en el árbol.";
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        // Inserta un nuevo valor en el árbol binario
        private Nodo InsertarNodo(Nodo actual, int valor)
        {
            if (actual == null)
                return new Nodo(valor); // Crea nuevo nodo

            if (valor < actual.Valor)
                actual.Izquierda = InsertarNodo(actual.Izquierda, valor);
            else if (valor > actual.Valor)
                actual.Derecha = InsertarNodo(actual.Derecha, valor);

            return actual;
        }

        // Busca un valor en el árbol binario
        private bool BuscarNodo(Nodo actual, int valor)
        {
            if (actual == null) return false;

            if (valor == actual.Valor) return true;

            return valor < actual.Valor
                ? BuscarNodo(actual.Izquierda, valor)
                : BuscarNodo(actual.Derecha, valor);
        }

        // Evento para dibujar el árbol binario en el panel
        private void pnlArbol_Paint(object sender, PaintEventArgs e)
        {
            if (raiz != null)
            {
                // Dibuja el nodo raíz y sus hijos
                DibujarArbol(e.Graphics, raiz, pnlArbol.Width / 2, 30, pnlArbol.Width / 4);
            }
        }

        // Método recursivo para dibujar el árbol
        private void DibujarArbol(Graphics g, Nodo nodo, int x, int y, int separacion)
        {
            if (nodo == null) return;

            // Dibuja nodo (círculo verde claro con borde negro y número)
            g.FillEllipse(Brushes.LightGreen, x - 15, y - 15, 30, 30);
            g.DrawEllipse(Pens.Black, x - 15, y - 15, 30, 30);
            g.DrawString(nodo.Valor.ToString(), new Font("Arial", 10), Brushes.Black, x - 10, y - 8);

            // Dibuja conexión y recursivamente los hijos
            if (nodo.Izquierda != null)
            {
                g.DrawLine(Pens.Black, x, y, x - separacion, y + 50);
                DibujarArbol(g, nodo.Izquierda, x - separacion, y + 50, separacion / 2);
            }

            if (nodo.Derecha != null)
            {
                g.DrawLine(Pens.Black, x, y, x + separacion, y + 50);
                DibujarArbol(g, nodo.Derecha, x + separacion, y + 50, separacion / 2);
            }
        }

        // ----- MÉTODOS DE RECORRIDO ----- 

        // Recorrido Preorden (Raíz - Izquierda - Derecha)
        private List<int> ObtenerPreorden(Nodo nodo)
        {
            List<int> recorrido = new List<int>();
            if (nodo != null)
            {
                recorrido.Add(nodo.Valor);
                recorrido.AddRange(ObtenerPreorden(nodo.Izquierda));
                recorrido.AddRange(ObtenerPreorden(nodo.Derecha));
            }
            return recorrido;
        }

        // Recorrido Inorden (Izquierda - Raíz - Derecha)
        private List<int> ObtenerInorden(Nodo nodo)
        {
            List<int> recorrido = new List<int>();
            if (nodo != null)
            {
                recorrido.AddRange(ObtenerInorden(nodo.Izquierda));
                recorrido.Add(nodo.Valor);
                recorrido.AddRange(ObtenerInorden(nodo.Derecha));
            }
            return recorrido;
        }

        // Recorrido Posorden (Izquierda - Derecha - Raíz)
        private List<int> ObtenerPosorden(Nodo nodo)
        {
            List<int> recorrido = new List<int>();
            if (nodo != null)
            {
                recorrido.AddRange(ObtenerPosorden(nodo.Izquierda));
                recorrido.AddRange(ObtenerPosorden(nodo.Derecha));
                recorrido.Add(nodo.Valor);
            }
            return recorrido;
        }

        // Panel de Preorden
        private void pnlPreorden_Paint(object sender, PaintEventArgs e)
        {
            List<int> valores = ObtenerPreorden(raiz);
            DibujarRecorrido(e.Graphics, valores, "Preorden", Brushes.LightCoral);
        }

        // Panel de Inorden
        private void pnlInorden_Paint(object sender, PaintEventArgs e)
        {
            List<int> valores = ObtenerInorden(raiz);
            DibujarRecorrido(e.Graphics, valores, "Inorden", Brushes.LightBlue);
        }

        // Panel de Posorden
        private void pnlPosorden_Paint(object sender, PaintEventArgs e)
        {
            List<int> valores = ObtenerPosorden(raiz);
            DibujarRecorrido(e.Graphics, valores, "Posorden", Brushes.LightGoldenrodYellow);
        }

        // Método para dibujar texto de recorrido en el panel correspondiente
        private void DibujarRecorrido(Graphics g, List<int> recorrido, string titulo, Brush colorEsfera)
        {
            Font fuente = new Font("Arial", 10);
            int x = 10, y = 10;

            // Dibuja el título
            g.DrawString(titulo + ":", fuente, Brushes.DarkGreen, x, y);
            x += 80;

            // Dibuja los números en esferas de colores
            foreach (int numero in recorrido)
            {
                g.FillEllipse(colorEsfera, x - 15, y - 15, 30, 30);
                g.DrawEllipse(Pens.Black, x - 15, y - 15, 30, 30);
                g.DrawString(numero.ToString(), fuente, Brushes.Black, x - 10, y - 8);
                x += 40;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?",
                                             "Confirmar salida",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}