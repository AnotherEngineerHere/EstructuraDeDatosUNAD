using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// desarrollado por Juan Andres Orozco Nu�ez
// Curso estructura de datos
// 301305A_2031
// Tutor  FIDIAS RAFAEL BARROS�MONTES

namespace arbolesbinarios
{
    public partial class Form1 : Form
    {
        // Nodo ra�z del �rbol binario
        private Nodo raiz = null;

        // Constructor principal del formulario
        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes visuales del formulario
        }

        // Evento cuando el formulario se carga por primera vez
        private void Form1_Load(object sender, EventArgs e)
        {
            // No se requiere l�gica al cargar
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            // Puedes agregar aqu� la l�gica para manejar el cambio de texto
        }
        // Evento que ocurre cuando el bot�n "Agregar" es presionado
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verifica si el texto es un n�mero entero v�lido
            if (int.TryParse(txtValor.Text, out int numero))
            {
                // Inserta el valor en el �rbol
                raiz = InsertarNodo(raiz, numero);

                // Mensaje de confirmaci�n
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
                // Muestra mensaje si no es un n�mero v�lido
                MessageBox.Show("Por favor ingrese un n�mero v�lido.");
            }
        }

        // Evento del bot�n "Buscar"
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verifica si el texto es un n�mero
            if (int.TryParse(txtValor.Text, out int numero))
            {
                // Busca el nodo
                bool encontrado = BuscarNodo(raiz, numero);

                // Muestra si fue encontrado o no
                string mensaje = encontrado
                    ? $"El nodo {numero} S� se encuentra en el �rbol."
                    : $"El nodo {numero} NO se encuentra en el �rbol.";
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Ingrese un n�mero v�lido.");
            }
        }

        // Inserta un nuevo valor en el �rbol binario
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

        // Busca un valor en el �rbol binario
        private bool BuscarNodo(Nodo actual, int valor)
        {
            if (actual == null) return false;

            if (valor == actual.Valor) return true;

            return valor < actual.Valor
                ? BuscarNodo(actual.Izquierda, valor)
                : BuscarNodo(actual.Derecha, valor);
        }

        // Evento para dibujar el �rbol binario en el panel
        private void pnlArbol_Paint(object sender, PaintEventArgs e)
        {
            if (raiz != null)
            {
                // Dibuja el nodo ra�z y sus hijos
                DibujarArbol(e.Graphics, raiz, pnlArbol.Width / 2, 30, pnlArbol.Width / 4);
            }
        }

        // M�todo recursivo para dibujar el �rbol
        private void DibujarArbol(Graphics g, Nodo nodo, int x, int y, int separacion)
        {
            if (nodo == null) return;

            // Dibuja nodo (c�rculo verde claro con borde negro y n�mero)
            g.FillEllipse(Brushes.LightGreen, x - 15, y - 15, 30, 30);
            g.DrawEllipse(Pens.Black, x - 15, y - 15, 30, 30);
            g.DrawString(nodo.Valor.ToString(), new Font("Arial", 10), Brushes.Black, x - 10, y - 8);

            // Dibuja conexi�n y recursivamente los hijos
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

        // ----- M�TODOS DE RECORRIDO ----- 

        // Recorrido Preorden (Ra�z - Izquierda - Derecha)
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

        // Recorrido Inorden (Izquierda - Ra�z - Derecha)
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

        // Recorrido Posorden (Izquierda - Derecha - Ra�z)
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

        // M�todo para dibujar texto de recorrido en el panel correspondiente
        private void DibujarRecorrido(Graphics g, List<int> recorrido, string titulo, Brush colorEsfera)
        {
            Font fuente = new Font("Arial", 10);
            int x = 10, y = 10;

            // Dibuja el t�tulo
            g.DrawString(titulo + ":", fuente, Brushes.DarkGreen, x, y);
            x += 80;

            // Dibuja los n�meros en esferas de colores
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
            DialogResult resultado = MessageBox.Show("�Est�s seguro de que deseas salir?",
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