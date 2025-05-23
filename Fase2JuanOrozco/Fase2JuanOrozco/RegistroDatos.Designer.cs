
namespace Fase2JuanOrozco
{
    partial class RegistroDatos
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
            idTxt = new Label();
            nombreTxt = new Label();
            tecnicaTxt = new Label();
            costoClaseTxt = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            nameTxtBox = new TextBox();
            idTxtBox = new TextBox();
            txtNumeroClases = new TextBox();
            generoTxt = new Label();
            masculinoCheckBox = new CheckBox();
            femeninoCheckBox = new CheckBox();
            btnGuardar = new Button();
            btnCalcularReporte = new Button();
            btnSalir = new Button();
            txtCostoClase = new Label();
            SuspendLayout();
            // 
            // idTxt
            // 
            idTxt.AutoSize = true;
            idTxt.Location = new Point(35, 45);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(18, 15);
            idTxt.TabIndex = 0;
            idTxt.Text = "ID";
            // 
            // nombreTxt
            // 
            nombreTxt.AutoSize = true;
            nombreTxt.Location = new Point(35, 83);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(51, 15);
            nombreTxt.TabIndex = 1;
            nombreTxt.Text = "Nombre";
            // 
            // tecnicaTxt
            // 
            tecnicaTxt.AutoSize = true;
            tecnicaTxt.Location = new Point(35, 118);
            tecnicaTxt.Name = "tecnicaTxt";
            tecnicaTxt.Size = new Size(91, 15);
            tecnicaTxt.TabIndex = 2;
            tecnicaTxt.Text = "Tecnica artistica";
            // 
            // costoClaseTxt
            // 
            costoClaseTxt.AutoSize = true;
            costoClaseTxt.Location = new Point(35, 154);
            costoClaseTxt.Name = "costoClaseTxt";
            costoClaseTxt.Size = new Size(88, 15);
            costoClaseTxt.TabIndex = 3;
            costoClaseTxt.Text = "Costo por clase";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 196);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 4;
            label5.Text = "Numero de clases";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dibujo", "Pintura", "Escritura", "Fotografía", "Grabado" });
            comboBox1.Location = new Point(190, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(190, 83);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(158, 23);
            nameTxtBox.TabIndex = 6;
            // 
            // idTxtBox
            // 
            idTxtBox.Location = new Point(190, 45);
            idTxtBox.Name = "idTxtBox";
            idTxtBox.Size = new Size(158, 23);
            idTxtBox.TabIndex = 7;
            // 
            // txtNumeroClases
            // 
            txtNumeroClases.Location = new Point(190, 193);
            txtNumeroClases.Name = "txtNumeroClases";
            txtNumeroClases.Size = new Size(158, 23);
            txtNumeroClases.TabIndex = 9;
            // 
            // generoTxt
            // 
            generoTxt.AutoSize = true;
            generoTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generoTxt.Location = new Point(433, 40);
            generoTxt.Name = "generoTxt";
            generoTxt.Size = new Size(65, 21);
            generoTxt.TabIndex = 10;
            generoTxt.Text = "Genero";
            // 
            // masculinoCheckBox
            // 
            masculinoCheckBox.AutoSize = true;
            masculinoCheckBox.Location = new Point(433, 68);
            masculinoCheckBox.Name = "masculinoCheckBox";
            masculinoCheckBox.Size = new Size(81, 19);
            masculinoCheckBox.TabIndex = 12;
            masculinoCheckBox.Text = "Masculino";
            masculinoCheckBox.UseVisualStyleBackColor = true;
            // 
            // femeninoCheckBox
            // 
            femeninoCheckBox.AutoSize = true;
            femeninoCheckBox.Location = new Point(433, 93);
            femeninoCheckBox.Name = "femeninoCheckBox";
            femeninoCheckBox.Size = new Size(79, 19);
            femeninoCheckBox.TabIndex = 13;
            femeninoCheckBox.Text = "Femenino";
            femeninoCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(50, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 44);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCalcularReporte
            // 
            btnCalcularReporte.Location = new Point(254, 303);
            btnCalcularReporte.Name = "btnCalcularReporte";
            btnCalcularReporte.Size = new Size(119, 44);
            btnCalcularReporte.TabIndex = 15;
            btnCalcularReporte.Text = "Calcular/Mostrar Reporte";
            btnCalcularReporte.UseVisualStyleBackColor = true;
            btnCalcularReporte.Click += btnCalcularReporte_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(459, 303);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(119, 44);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtCostoClase
            // 
            txtCostoClase.AutoSize = true;
            txtCostoClase.Location = new Point(195, 154);
            txtCostoClase.Name = "txtCostoClase";
            txtCostoClase.Size = new Size(22, 15);
            txtCostoClase.TabIndex = 17;
            txtCostoClase.Text = "$ 0";
            // 
            // RegistroDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 377);
            Controls.Add(txtCostoClase);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcularReporte);
            Controls.Add(btnGuardar);
            Controls.Add(femeninoCheckBox);
            Controls.Add(masculinoCheckBox);
            Controls.Add(generoTxt);
            Controls.Add(txtNumeroClases);
            Controls.Add(idTxtBox);
            Controls.Add(nameTxtBox);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(costoClaseTxt);
            Controls.Add(tecnicaTxt);
            Controls.Add(nombreTxt);
            Controls.Add(idTxt);
            Name = "RegistroDatos";
            Text = "RegistroDatos";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label idTxt;
        private Label nombreTxt;
        private Label tecnicaTxt;
        private Label costoClaseTxt;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox nameTxtBox;
        private TextBox idTxtBox;
        private TextBox txtNumeroClases;
        private Label generoTxt;
        private CheckBox masculinoCheckBox;
        private CheckBox femeninoCheckBox;
        private Button btnGuardar;
        private Button btnCalcularReporte;
        private Button btnSalir;
        private Label txtCostoClase;
    }
}