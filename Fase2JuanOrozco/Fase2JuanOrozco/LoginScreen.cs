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
                MessageBox.Show("Contrase�a correcta", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegistroDatos registroForm = new RegistroDatos();
                registroForm.ShowDialog(); // Abre el formulario de Registro como un cuadro de di�logo modal
            }
            else
            {
                MessageBox.Show("Contrase�a incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
