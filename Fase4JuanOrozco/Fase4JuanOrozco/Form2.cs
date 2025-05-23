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
    public partial class Form2 : Form
    {
        // Constructor del formulario
        public Form2()
        {
            InitializeComponent(); // Inicializa los componentes del formulario

            // Establece la fecha actual en el label al iniciar la aplicación
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        // Evento que se ejecuta cuando el formulario se carga
        private void Form2_Load(object sender, EventArgs e)
        {
            // Este evento no realiza ninguna acción en este momento
        }

        // Evento que se ejecuta cuando el usuario hace clic en el botón "Ingresar"
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verifica si la contraseña ingresada es correcta
            if (txtPassword.Text == "1234")
            {
                // Muestra un mensaje de bienvenida personalizado
                MessageBox.Show("Bienvenido a sus Árboles Binarios", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Crea una nueva instancia del formulario principal
                Form1 ventanaPrincipal = new Form1();

                // Muestra el formulario principal
                ventanaPrincipal.Show();

                // Oculta el formulario de login
                this.Hide();
            }
            else
            {
                // Muestra un mensaje de error si la contraseña es incorrecta
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento asociado a un clic en el label7 (actualmente sin funcionalidad)
        private void label7_Click(object sender, EventArgs e)
        {
            // No se ha implementado ninguna funcionalidad
        }
    }
}