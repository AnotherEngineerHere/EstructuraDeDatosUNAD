namespace Fase3JuanOrozco
{
    public partial class FormularioIngreso : Form
    {
        private const string CONTRASEÑA_CORRECTA = "1357";
        public FormularioIngreso()
        {
            InitializeComponent();
            txtPassword.ReadOnly = true;
            txtPassword.PasswordChar = '*';


        }
        // Método para agregar números al campo de contraseña
        private void AgregarNumero(object sender, EventArgs e)
        {
            Button? boton = sender as Button;
            if (boton != null)
            {
                txtPassword.Text += boton.Text;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) { AgregarNumero(sender, e); }
        private void button2_Click(object sender, EventArgs e) { AgregarNumero(sender, e); }
        private void button3_Click(object sender, EventArgs e) { AgregarNumero(sender, e); }
        private void button4_Click(object sender, EventArgs e) { AgregarNumero(sender, e); }
        private void button5_Click(object sender, EventArgs e) { AgregarNumero(sender, e); }
        private void button6_Click(object sender, EventArgs e) { AgregarNumero(sender, e); }
        private void button7_Click(object sender, EventArgs e) { AgregarNumero(sender, e); }
        private void button8_Click(object sender, EventArgs e) { AgregarNumero(sender, e); }
        private void button9_Click(object sender, EventArgs e) { AgregarNumero(sender, e); }


        private void salirButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?",
                                                         "Confirmación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void LimpiarPassword()
        {
            txtPassword.Clear();
        }
        private void limpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarPassword();
         

        }

        private void ingresoButton_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == CONTRASEÑA_CORRECTA)
            {
                MessageBox.Show("Acceso concedido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form = new Form1();
                form.Show();
                this.Hide();
                
                
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarPassword();
            }
        }

        private void acercaDe_Click(object sender, EventArgs e)
        {
            acercaDeDownLabel.Text = "Estructuras de Datos|Juan Orozco|Grupo301305_93";
            acercaDeDownLabel.Font = new Font(acercaDeDownLabel.Font, FontStyle.Bold);
            acercaDeDownLabel.ForeColor = Color.Red;

        }

        private void FormularioIngreso_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
