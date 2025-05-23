namespace Fase5_Juan_Orozco
{
    partial class FormularioTarea5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            btnTarea2 = new Button();
            btnFase3 = new Button();
            btnFase4 = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(27, 395);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnTarea2
            // 
            btnTarea2.Location = new Point(27, 88);
            btnTarea2.Name = "btnTarea2";
            btnTarea2.Size = new Size(125, 74);
            btnTarea2.TabIndex = 1;
            btnTarea2.Text = "Tarea 2";
            btnTarea2.UseVisualStyleBackColor = true;
            btnTarea2.Click += btnTarea2_Click;
            // 
            // btnFase3
            // 
            btnFase3.Location = new Point(297, 88);
            btnFase3.Name = "btnFase3";
            btnFase3.Size = new Size(125, 74);
            btnFase3.TabIndex = 2;
            btnFase3.Text = "Tarea 3";
            btnFase3.UseVisualStyleBackColor = true;
            btnFase3.Click += btnFase3_Click;
            // 
            // btnFase4
            // 
            btnFase4.Location = new Point(523, 88);
            btnFase4.Name = "btnFase4";
            btnFase4.Size = new Size(125, 74);
            btnFase4.TabIndex = 3;
            btnFase4.Text = "Tarea 4";
            btnFase4.UseVisualStyleBackColor = true;
            btnFase4.Click += btnFase4_Click;
            // 
            // FormularioTarea5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFase4);
            Controls.Add(btnFase3);
            Controls.Add(btnTarea2);
            Controls.Add(btnSalir);
            Name = "FormularioTarea5";
            Text = "FormularioTarea5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnTarea2;
        private Button btnFase3;
        private Button btnFase4;
    }
}