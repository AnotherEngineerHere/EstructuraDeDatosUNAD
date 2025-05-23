
namespace Fase2JuanOrozco
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 41);
            label1.Name = "label1";
            label1.Size = new Size(266, 30);
            label1.TabIndex = 0;
            label1.Text = "Curso Estructura de Datos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 103);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 1;
            label2.Text = "Juan Andres Orozco Nuñez";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 174);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(176, 306);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 33);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Validar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(181, 171);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 389);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginScreen";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private TextBox txtPassword;
    }
}
