namespace Fase2JuanOrozco
{
    partial class Reporte
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
            button1 = new Button();
            label1 = new Label();
            fechaTxt = new Label();
            reporteTxt = new Label();
            label2 = new Label();
            valorTotalTxt = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(654, 384);
            button1.Name = "button1";
            button1.Size = new Size(134, 54);
            button1.TabIndex = 0;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 25);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha de Registro";
            // 
            // fechaTxt
            // 
            fechaTxt.AutoSize = true;
            fechaTxt.Location = new Point(380, 25);
            fechaTxt.Name = "fechaTxt";
            fechaTxt.Size = new Size(0, 15);
            fechaTxt.TabIndex = 2;
            // 
            // reporteTxt
            // 
            reporteTxt.AutoSize = true;
            reporteTxt.Location = new Point(63, 97);
            reporteTxt.Name = "reporteTxt";
            reporteTxt.Size = new Size(0, 15);
            reporteTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 404);
            label2.Name = "label2";
            label2.Size = new Size(218, 15);
            label2.TabIndex = 4;
            label2.Text = "Para un total de costo de matricula por: ";
            // 
            // valorTotalTxt
            // 
            valorTotalTxt.AutoSize = true;
            valorTotalTxt.Location = new Point(434, 404);
            valorTotalTxt.Name = "valorTotalTxt";
            valorTotalTxt.RightToLeft = RightToLeft.No;
            valorTotalTxt.Size = new Size(0, 15);
            valorTotalTxt.TabIndex = 5;
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(valorTotalTxt);
            Controls.Add(label2);
            Controls.Add(reporteTxt);
            Controls.Add(fechaTxt);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Reporte";
            Text = "Reporte";
            Load += Reporte_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label fechaTxt;
        private Label reporteTxt;
        private Label label2;
        private Label valorTotalTxt;
    }
}