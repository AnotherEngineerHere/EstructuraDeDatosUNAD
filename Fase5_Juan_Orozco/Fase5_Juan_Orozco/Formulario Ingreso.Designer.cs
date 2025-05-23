namespace Fase5_Juan_Orozco
{
    partial class Form1
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
            txtPassword = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 224);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(208, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 96);
            label2.Name = "label2";
            label2.Size = new Size(333, 54);
            label2.TabIndex = 2;
            label2.Text = " Evaluacion Final";
            // 
            // button1
            // 
            button1.Location = new Point(418, 432);
            button1.Name = "button1";
            button1.Size = new Size(140, 58);
            button1.TabIndex = 3;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 521);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Formulario Ingreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private Button button1;
    }
}
