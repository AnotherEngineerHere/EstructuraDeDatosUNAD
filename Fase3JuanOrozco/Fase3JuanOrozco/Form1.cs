using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fase3JuanOrozco
{
    public partial class Form1 : Form
    {
        private Stack<EstructuraDatosAfiliado> pilaAfiliados = new Stack<EstructuraDatosAfiliado>();
        private Queue<EstructuraDatosAfiliado> colaAfiliados = new Queue<EstructuraDatosAfiliado>();
        private List<EstructuraDatosAfiliado> listaAfiliados = new List<EstructuraDatosAfiliado>();

        public Form1()
        {
            InitializeComponent();

            txtId.KeyPress += ValidarSoloNumeros;
            txtSalario.KeyPress += ValidarSoloNumeros;
            txtNombre.KeyPress += ValidarSoloLetras;

            cbTipoId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoEstructura.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy";
        }

        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidarSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private decimal CalcularSubsidio(int estrato, bool afiliadoSISBEN, decimal salario)
        {
            decimal subsidio = 0;

            if (afiliadoSISBEN)
            {
                switch (estrato)
                {
                    case 1: subsidio = 450000; break;
                    case 2: subsidio = 350000; break;
                    case 3: subsidio = 250000; break;
                    case 4: subsidio = 150000; break;
                    case 5:
                    case 6: subsidio = 0; break;
                }
                if (salario < 500000) subsidio += 50000;
            }
            else
            {
                switch (estrato)
                {
                    case 1: subsidio = 300000; break;
                    case 2: subsidio = 200000; break;
                    case 3: subsidio = 100000; break;
                    case 4: subsidio = 50000; break;
                    case 5:
                    case 6: subsidio = 0; break;
                }
                if (salario < 1000000) subsidio += 150000;
            }

            return subsidio;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                cbTipoId.SelectedIndex == -1 ||
                cbEstrato.SelectedIndex == -1 ||
                cbTipoEstructura.SelectedIndex == -1 ||
                (!rbSi.Checked && !rbNo.Checked))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var afiliado = new EstructuraDatosAfiliado
            {
                TipoId = cbTipoId.SelectedItem.ToString(),
                Id = txtId.Text,
                Nombre = txtNombre.Text,
                Salario = decimal.Parse(txtSalario.Text),
                Estrato = int.Parse(cbEstrato.SelectedItem.ToString()),
                AfiliadoSISBEN = rbSi.Checked,
                FechaAfiliacion = dtpFecha.Value
            };

            afiliado.Subsidio = CalcularSubsidio(afiliado.Estrato, afiliado.AfiliadoSISBEN, afiliado.Salario);
            txtSubsidio.Text = afiliado.Subsidio.ToString("C");

            switch (cbTipoEstructura.SelectedItem.ToString())
            {
                case "Pila":
                    pilaAfiliados.Push(afiliado);
                    break;
                case "Cola":
                    colaAfiliados.Enqueue(afiliado);
                    break;
                case "Lista":
                    listaAfiliados.Add(afiliado);
                    break;
            }

            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            if (cbTipoEstructura.SelectedItem == null) return;

           
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            switch (cbTipoEstructura.SelectedItem.ToString())
            {
                case "Pila":
                    txtReporte.Text = $"Total subsidios: {pilaAfiliados.Sum(a => a.Subsidio):C}";
                    break;
                case "Cola":
                    txtReporte.Text = $"Total registros: {colaAfiliados.Count}";
                    break;
                case "Lista":
                    txtReporte.Text = $"Promedio de salarios: {(listaAfiliados.Count > 0 ? listaAfiliados.Average(a => a.Salario) : 0):C}";
                    break;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbTipoEstructura.SelectedItem == null) return;

            if (MessageBox.Show("¿Desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                switch (cbTipoEstructura.SelectedItem.ToString())
                {
                    case "Pila":
                        if (pilaAfiliados.Count > 0) pilaAfiliados.Pop();
                        break;
                    case "Cola":
                        if (colaAfiliados.Count > 0) colaAfiliados.Dequeue();
                        break;
                    case "Lista":
                        var afiliado = listaAfiliados.FirstOrDefault(a => a.Id == txtId.Text);
                        if (afiliado != null) listaAfiliados.Remove(afiliado);
                        else MessageBox.Show("Afiliado no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                ActualizarDataGridView();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtSalario.Clear();
            txtSubsidio.Clear();
            cbTipoId.SelectedIndex = -1;
            cbEstrato.SelectedIndex = -1;
            cbTipoEstructura.SelectedIndex = -1;
            rbSi.Checked = false;
            rbNo.Checked = false;
            dtpFecha.Value = DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

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
