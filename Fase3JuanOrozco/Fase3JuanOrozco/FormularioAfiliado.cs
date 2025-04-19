using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fase3JuanOrozco
{
    public partial class FormularioAfiliado : Form
    {
        private Stack<EstructuraDatosAfiliado> pilaAfiliados = new Stack<EstructuraDatosAfiliado>();
        private Queue<EstructuraDatosAfiliado> colaAfiliados = new Queue<EstructuraDatosAfiliado>();
        private List<EstructuraDatosAfiliado> listaAfiliados = new List<EstructuraDatosAfiliado>();

        public FormularioAfiliado()
        {
            InitializeComponent();
            txtSubsidio.Enabled = false;
            txtId.KeyPress += ValidarSoloNumeros;
            txtSalario.KeyPress += ValidarSoloNumeros;
            txtNombre.KeyPress += ValidarSoloLetras;

            cbTipoId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoEstructura.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            cbEstrato.SelectedIndexChanged += CalcularSubsidioAutomaticamente;
            txtSalario.TextChanged += CalcularSubsidioAutomaticamente;
            rbSi.CheckedChanged += CalcularSubsidioAutomaticamente;
            rbNo.CheckedChanged += CalcularSubsidioAutomaticamente;
            dataGridPila.ReadOnly = true;
            dataGridCola.ReadOnly = true;
            dataGridLista.ReadOnly = true;

            dataGridPila.AllowUserToAddRows = false;
            dataGridCola.AllowUserToAddRows = false;
            dataGridLista.AllowUserToAddRows = false;

            dataGridPila.AllowUserToDeleteRows = false;
            dataGridCola.AllowUserToDeleteRows = false;
            dataGridLista.AllowUserToDeleteRows = false;



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
                    case 5: subsidio = 0; break;
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
                    case 5: subsidio = 0; break;
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
                    MessageBox.Show("Pila.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Cola":
                    colaAfiliados.Enqueue(afiliado);
                    MessageBox.Show("Cola", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Lista":
                    listaAfiliados.Add(afiliado);
                    MessageBox.Show("Lista", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {

            switch (cbTipoEstructura.SelectedItem.ToString())
            {
                case "Pila":
                    dataGridPila.DataSource = pilaAfiliados.ToList();
                    break;
                case "Cola":
                    dataGridCola.DataSource = colaAfiliados.ToList();
                    break;
                case "Lista":
                    dataGridLista.DataSource = listaAfiliados.ToList();
                    break;
            }
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
        private void CalcularSubsidioAutomaticamente(object sender, EventArgs e)
        {
            if (cbEstrato.SelectedIndex != -1 && decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                int estrato = int.Parse(cbEstrato.SelectedItem.ToString());
                bool afiliadoSISBEN = rbSi.Checked;

                decimal subsidio = CalcularSubsidio(estrato, afiliadoSISBEN, salario);
                txtSubsidio.Text = subsidio.ToString("C");
            }
            else
            {
                txtSubsidio.Clear();
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
                        dataGridPila.DataSource = null;

                        break;
                    case "Cola":
                        if (colaAfiliados.Count > 0) colaAfiliados.Dequeue();
                        dataGridCola.DataSource = null;

                        break;
                    case "Lista":

                        var afiliado = listaAfiliados.FirstOrDefault(a => a.Id == txtId.Text);
                        if (afiliado != null)
                        {
                            dataGridLista.DataSource = null;
                            listaAfiliados.Remove(afiliado);
                        }

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
        private void reportePila_Click(object sender, EventArgs e)
        {
            decimal totalSubsidios = pilaAfiliados.Sum(a => a.Subsidio);
            MessageBox.Show($"Total subsidios en pila: {totalSubsidios:C}", "Reporte Pila", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void borrarReportePila_Click(object sender, EventArgs e)
        {
            if (pilaAfiliados.Count == 0)
            {
                MessageBox.Show("No hay registros en la pila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Desea borrar el último registro de la pila?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pilaAfiliados.Pop();  // Borra solo el último (LIFO)
                ActualizarDataGridView();
                MessageBox.Show("Último registro de la pila eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void reporteCola_Click(object sender, EventArgs e)
        {
            int cantidad = colaAfiliados.Count;
            MessageBox.Show($"Cantidad de registros en cola: {cantidad}", "Reporte Cola", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reporteLista_Click(object sender, EventArgs e)
        {
            decimal promedio = listaAfiliados.Count > 0 ? listaAfiliados.Average(a => a.Salario) : 0;
            MessageBox.Show($"Promedio de salarios en lista: {promedio:C}", "Reporte Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void eliminarLista_Click(object sender, EventArgs e)
        {
            string inputId = Interaction.InputBox("Ingrese el número de documento del afiliado a eliminar:", "Eliminar Afiliado", "");

            if (string.IsNullOrWhiteSpace(inputId))
            {
                MessageBox.Show("Debe ingresar un número de documento válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var afiliado = listaAfiliados.FirstOrDefault(a => a.Id == inputId);
            if (afiliado != null)
            {
                listaAfiliados.Remove(afiliado);
                ActualizarDataGridView();
                MessageBox.Show("Afiliado eliminado de la lista.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Afiliado no encontrado en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BorrarReporteCola_Click(object sender, EventArgs e)
        {
            if (colaAfiliados.Count == 0)
            {
                MessageBox.Show("No hay registros en la cola.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Desea borrar el primer registro de la cola?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                colaAfiliados.Dequeue();  // Borra solo el primero (FIFO)
                ActualizarDataGridView();
                MessageBox.Show("Primer registro de la cola eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
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

    }


}
