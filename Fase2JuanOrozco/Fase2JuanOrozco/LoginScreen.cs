namespace Fase2JuanOrozco
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (password == "123")
            {
                MessageBox.Show("Contraseña correcta", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegistroDatos registroForm = new RegistroDatos();
                registroForm.ShowDialog(); // Abre el formulario de Registro como un cuadro de diálogo modal
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
