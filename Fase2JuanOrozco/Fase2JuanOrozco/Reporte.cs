using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2JuanOrozco
{
    public partial class Reporte : Form
    {
        private GestionParticipantes participante;

        public Reporte(GestionParticipantes participante)

        {
            InitializeComponent();
            this.participante = participante;

        }

        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            fechaTxt.Text = DateTime.Now.ToShortDateString();
            reporteTxt.Text = $"El estudiante {participante.Nombre} identificado con cédula de ciudadanía número " +
                     $"{participante.ID}, de género **{participante.Genero}**, ha sido inscrito en el curso " +
                     $"de la técnica {participante.Tecnica}.\n\n" +
                     $"El cual cursará en un lapso de {participante.NumeroClases} días, " +
                     $"con un costo por clases de {participante.CostoPorClase:C}.\n\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
