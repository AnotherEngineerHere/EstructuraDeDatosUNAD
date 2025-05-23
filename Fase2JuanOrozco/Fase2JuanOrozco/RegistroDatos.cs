using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2JuanOrozco
{
    public partial class RegistroDatos : Form
    {

        public GestionParticipantes Participante;

        public RegistroDatos()
        {
            InitializeComponent();
            btnCalcularReporte.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; // Solo permitir selección, no edición
            comboBox1.Text = "Seleccione una técnica";
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

            // Configurar eventos para los CheckBox
            masculinoCheckBox.CheckedChanged += new EventHandler(masculinoCheckBox_CheckedChanged);
            femeninoCheckBox.CheckedChanged += new EventHandler(femeninoCheckBox_CheckedChanged);
        }

        private void btnCalcularReporte_Click(object sender, EventArgs e)
        {
          Reporte reporte = new Reporte(Participante);
            reporte.Show();
        }

        private ComboBox GetComboBox1()
        {
            return comboBox1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una técnica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int id = int.Parse(idTxtBox.Text);
                string nombre = nameTxtBox.Text;
                string tecnica = comboBox1.SelectedItem?.ToString() ?? string.Empty;
                int numeroClases = int.Parse(txtNumeroClases.Text);
                decimal costoPorClase = decimal.Parse(txtCostoClase.Text.Replace("$", "").Replace(".", "").Trim());
                string genero = masculinoCheckBox.Checked ? "Masculino" : "Femenino";

                Participante = new GestionParticipantes(id, nombre, tecnica, numeroClases, costoPorClase, genero);

                MessageBox.Show($"Datos guardados correctamente:\n\nID: {Participante.ID}\nNombre: {Participante.Nombre}\nTécnica: {Participante.Tecnica}\nNúmero de Clases: {Participante.NumeroClases}\nCosto por Clase: {Participante.CostoPorClase:C}\nGénero: {Participante.Genero}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCalcularReporte.Enabled = true;
            }
        }

        private bool ValidarCampos()
        {
            if (!int.TryParse(idTxtBox.Text, out _))
            {
                MessageBox.Show("El ID debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(nameTxtBox.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El Nombre debe contener solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtNumeroClases.Text, out int numeroClases) || numeroClases <= 0)
            {
                MessageBox.Show("El Número de clase debe ser un entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!masculinoCheckBox.Checked && !femeninoCheckBox.Checked)
            {
                MessageBox.Show("Debe seleccionar el género", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Dibujo":
                        txtCostoClase.Text = "$ 70.000";
                        break;
                    case "Pintura":
                        txtCostoClase.Text = "$ 85.000";
                        break;
                    case "Escritura":
                        txtCostoClase.Text = "$ 100.000";
                        break;
                    case "Fotografía":
                        txtCostoClase.Text = "$ 90.000";
                        break;
                    case "Grabado":
                        txtCostoClase.Text = "$ 75.000";
                        break;
                    default:
                        txtCostoClase.Text = "";
                        break;
                }
            }
        }

        private void masculinoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (masculinoCheckBox.Checked)
            {
                femeninoCheckBox.Checked = false;
            }
        }

        private void femeninoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (femeninoCheckBox.Checked)
            {
                masculinoCheckBox.Checked = false;
            }
        }

        private void idTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroClases_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCostoClase_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

