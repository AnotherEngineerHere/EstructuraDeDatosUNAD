namespace Fase5_Juan_Orozco
{
    public partial class Form1 : Form
    {

        private const string CONTRASEÑA_CORRECTA = "1357";
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == CONTRASEÑA_CORRECTA)
            {
                MessageBox.Show("Acceso concedido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormularioTarea5 form = new FormularioTarea5();
                form.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarPassword();
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
    }
}
