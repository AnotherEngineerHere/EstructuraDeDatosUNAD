using arbolesbinarios;
using Fase2JuanOrozco;
using Fase3JuanOrozco;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Fase5_Juan_Orozco
{
    public partial class FormularioTarea5 : Form
    {
        public FormularioTarea5()
        {
            InitializeComponent();
            this.FormClosing += FormularioTarea5_FormClosing;
        }

        private void FormularioTarea5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?",
                                                     "Confirmación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Disparará FormClosing
        }

        private void btnTarea2_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(() =>
            {
                Application.Run(new RegistroDatos());
            });
            hilo.SetApartmentState(ApartmentState.STA);
            hilo.Start();
        }

        private void btnFase3_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(() =>
            {
                Application.Run(new FormularioAfiliado());
            });
            hilo.SetApartmentState(ApartmentState.STA);
            hilo.Start();
        }

        private void btnFase4_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(() =>
            {
                Application.Run(new Form2());
            });
            hilo.SetApartmentState(ApartmentState.STA);
            hilo.Start();
        }
    }
}
