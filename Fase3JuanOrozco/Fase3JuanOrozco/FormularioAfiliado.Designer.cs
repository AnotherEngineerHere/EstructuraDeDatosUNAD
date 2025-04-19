
namespace Fase3JuanOrozco
{
    partial class FormularioAfiliado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            titulo = new Label();
            subtitulo = new Label();
            groupBoxAfiliado = new GroupBox();
            lblTipoId = new Label();
            cbTipoId = new ComboBox();
            lblId = new Label();
            txtId = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblSalario = new Label();
            txtSalario = new TextBox();
            lblEstrato = new Label();
            cbEstrato = new ComboBox();
            lblSISBEN = new Label();
            rbSi = new RadioButton();
            rbNo = new RadioButton();
            lblSubsidio = new Label();
            txtSubsidio = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblTipoEstructura = new Label();
            cbTipoEstructura = new ComboBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblCamposObligatorios = new Label();
            tabControl = new TabControl();
            tabPila = new TabPage();
            borrarReportePila = new Button();
            dataGridPila = new DataGridView();
            reportePila = new Button();
            txtReporte = new TextBox();
            btnReporte = new Button();
            btnEliminar = new Button();
            tabCola = new TabPage();
            BorrarReporteCola = new Button();
            reporteCola = new Button();
            dataGridCola = new DataGridView();
            tabLista = new TabPage();
            eliminarLista = new Button();
            reporteLista = new Button();
            dataGridLista = new DataGridView();
            groupBoxAfiliado.SuspendLayout();
            tabControl.SuspendLayout();
            tabPila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPila).BeginInit();
            tabCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCola).BeginInit();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLista).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Dock = DockStyle.Top;
            titulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titulo.Location = new Point(0, 23);
            titulo.Name = "titulo";
            titulo.Size = new Size(1046, 23);
            titulo.TabIndex = 0;
            titulo.Text = "SISTEMA DE VALIDACIÓN DE SUBSIDIO PARA AFILIADOS";
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtitulo
            // 
            subtitulo.Dock = DockStyle.Top;
            subtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            subtitulo.Location = new Point(0, 0);
            subtitulo.Name = "subtitulo";
            subtitulo.Size = new Size(1046, 23);
            subtitulo.TabIndex = 1;
            subtitulo.Text = "Subsidiar S.A";
            subtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxAfiliado
            // 
            groupBoxAfiliado.Controls.Add(lblTipoId);
            groupBoxAfiliado.Controls.Add(cbTipoId);
            groupBoxAfiliado.Controls.Add(lblId);
            groupBoxAfiliado.Controls.Add(txtId);
            groupBoxAfiliado.Controls.Add(lblNombre);
            groupBoxAfiliado.Controls.Add(txtNombre);
            groupBoxAfiliado.Controls.Add(lblSalario);
            groupBoxAfiliado.Controls.Add(txtSalario);
            groupBoxAfiliado.Controls.Add(lblEstrato);
            groupBoxAfiliado.Controls.Add(cbEstrato);
            groupBoxAfiliado.Controls.Add(lblSISBEN);
            groupBoxAfiliado.Controls.Add(rbSi);
            groupBoxAfiliado.Controls.Add(rbNo);
            groupBoxAfiliado.Controls.Add(lblSubsidio);
            groupBoxAfiliado.Controls.Add(txtSubsidio);
            groupBoxAfiliado.Controls.Add(lblFecha);
            groupBoxAfiliado.Controls.Add(dtpFecha);
            groupBoxAfiliado.Controls.Add(lblTipoEstructura);
            groupBoxAfiliado.Controls.Add(cbTipoEstructura);
            groupBoxAfiliado.Controls.Add(btnRegistrar);
            groupBoxAfiliado.Controls.Add(btnLimpiar);
            groupBoxAfiliado.Controls.Add(btnSalir);
            groupBoxAfiliado.Controls.Add(lblCamposObligatorios);
            groupBoxAfiliado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxAfiliado.Location = new Point(30, 64);
            groupBoxAfiliado.Name = "groupBoxAfiliado";
            groupBoxAfiliado.Size = new Size(1004, 495);
            groupBoxAfiliado.TabIndex = 2;
            groupBoxAfiliado.TabStop = false;
            groupBoxAfiliado.Text = "Datos del afiliado";
            // 
            // lblTipoId
            // 
            lblTipoId.Location = new Point(22, 28);
            lblTipoId.Name = "lblTipoId";
            lblTipoId.Size = new Size(218, 23);
            lblTipoId.TabIndex = 0;
            lblTipoId.Text = "Tipo de identificación (*)";
            // 
            // cbTipoId
            // 
            cbTipoId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoId.Items.AddRange(new object[] { "CC", "CE", "NIUP", "PAS" });
            cbTipoId.Location = new Point(279, 28);
            cbTipoId.Name = "cbTipoId";
            cbTipoId.Size = new Size(121, 23);
            cbTipoId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.Location = new Point(596, 28);
            lblId.Name = "lblId";
            lblId.Size = new Size(194, 23);
            lblId.TabIndex = 2;
            lblId.Text = "Número de identificación (*)";
            // 
            // txtId
            // 
            txtId.Location = new Point(845, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(22, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(218, 23);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre Completo(*)";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(279, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 5;
            // 
            // lblSalario
            // 
            lblSalario.Location = new Point(596, 77);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(100, 23);
            lblSalario.TabIndex = 6;
            lblSalario.Text = "Salario ($*)";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(845, 77);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 7;
            // 
            // lblEstrato
            // 
            lblEstrato.Location = new Point(22, 151);
            lblEstrato.Name = "lblEstrato";
            lblEstrato.Size = new Size(247, 23);
            lblEstrato.TabIndex = 8;
            lblEstrato.Text = "*Estrato Socioeconomico*";
            // 
            // cbEstrato
            // 
            cbEstrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstrato.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cbEstrato.Location = new Point(279, 151);
            cbEstrato.Name = "cbEstrato";
            cbEstrato.Size = new Size(121, 23);
            cbEstrato.TabIndex = 9;
            // 
            // lblSISBEN
            // 
            lblSISBEN.Location = new Point(720, 148);
            lblSISBEN.Name = "lblSISBEN";
            lblSISBEN.Size = new Size(133, 26);
            lblSISBEN.TabIndex = 10;
            lblSISBEN.Text = "¿Afiliado a SISBEN?";
            // 
            // rbSi
            // 
            rbSi.Location = new Point(732, 177);
            rbSi.Name = "rbSi";
            rbSi.Size = new Size(104, 24);
            rbSi.TabIndex = 11;
            rbSi.Text = "Si";
            // 
            // rbNo
            // 
            rbNo.Location = new Point(732, 198);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(104, 24);
            rbNo.TabIndex = 12;
            rbNo.Text = "No";
            // 
            // lblSubsidio
            // 
            lblSubsidio.Location = new Point(22, 261);
            lblSubsidio.Name = "lblSubsidio";
            lblSubsidio.Size = new Size(122, 23);
            lblSubsidio.TabIndex = 13;
            lblSubsidio.Text = "Valor Subsidio ($)";
            // 
            // txtSubsidio
            // 
            txtSubsidio.Location = new Point(279, 258);
            txtSubsidio.Name = "txtSubsidio";
            txtSubsidio.Size = new Size(121, 23);
            txtSubsidio.TabIndex = 14;
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(596, 244);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(100, 23);
            lblFecha.TabIndex = 15;
            lblFecha.Text = "Fecha Afiliacion";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(732, 241);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 16;
            // 
            // lblTipoEstructura
            // 
            lblTipoEstructura.Location = new Point(6, 352);
            lblTipoEstructura.Name = "lblTipoEstructura";
            lblTipoEstructura.Size = new Size(218, 23);
            lblTipoEstructura.TabIndex = 17;
            lblTipoEstructura.Text = "Tipo de Estructura (*)";
            // 
            // cbTipoEstructura
            // 
            cbTipoEstructura.Items.AddRange(new object[] { "Pila", "Cola", "Lista" });
            cbTipoEstructura.Location = new Point(279, 349);
            cbTipoEstructura.Name = "cbTipoEstructura";
            cbTipoEstructura.Size = new Size(121, 23);
            cbTipoEstructura.TabIndex = 18;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(642, 422);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 19;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(743, 422);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(857, 422);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click_1;
            // 
            // lblCamposObligatorios
            // 
            lblCamposObligatorios.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCamposObligatorios.ForeColor = Color.Red;
            lblCamposObligatorios.Location = new Point(720, 469);
            lblCamposObligatorios.Name = "lblCamposObligatorios";
            lblCamposObligatorios.Size = new Size(276, 23);
            lblCamposObligatorios.TabIndex = 22;
            lblCamposObligatorios.Text = "Los campos marcados con (*) son obligatorios.";
            lblCamposObligatorios.TextAlign = ContentAlignment.TopRight;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPila);
            tabControl.Controls.Add(tabCola);
            tabControl.Controls.Add(tabLista);
            tabControl.Location = new Point(14, 565);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1020, 200);
            tabControl.TabIndex = 3;
            // 
            // tabPila
            // 
            tabPila.Controls.Add(borrarReportePila);
            tabPila.Controls.Add(dataGridPila);
            tabPila.Controls.Add(reportePila);
            tabPila.Controls.Add(txtReporte);
            tabPila.Controls.Add(btnReporte);
            tabPila.Controls.Add(btnEliminar);
            tabPila.Location = new Point(4, 24);
            tabPila.Name = "tabPila";
            tabPila.Size = new Size(1012, 172);
            tabPila.TabIndex = 0;
            tabPila.Text = "Pila";
            // 
            // borrarReportePila
            // 
            borrarReportePila.Location = new Point(901, 108);
            borrarReportePila.Name = "borrarReportePila";
            borrarReportePila.Size = new Size(75, 23);
            borrarReportePila.TabIndex = 24;
            borrarReportePila.Text = "Eliminar";
            borrarReportePila.Click += borrarReportePila_Click;
            // 
            // dataGridPila
            // 
            dataGridPila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPila.Location = new Point(-4, 3);
            dataGridPila.Name = "dataGridPila";
            dataGridPila.Size = new Size(882, 196);
            dataGridPila.TabIndex = 3;
            // 
            // reportePila
            // 
            reportePila.Location = new Point(901, 19);
            reportePila.Name = "reportePila";
            reportePila.Size = new Size(75, 23);
            reportePila.TabIndex = 23;
            reportePila.Text = "Reporte";
            reportePila.Click += reportePila_Click;
            // 
            // txtReporte
            // 
            txtReporte.Dock = DockStyle.Fill;
            txtReporte.Location = new Point(0, 0);
            txtReporte.Multiline = true;
            txtReporte.Name = "txtReporte";
            txtReporte.Size = new Size(1012, 172);
            txtReporte.TabIndex = 0;
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(0, 0);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(75, 23);
            btnReporte.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(0, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            // 
            // tabCola
            // 
            tabCola.Controls.Add(BorrarReporteCola);
            tabCola.Controls.Add(reporteCola);
            tabCola.Controls.Add(dataGridCola);
            tabCola.Location = new Point(4, 24);
            tabCola.Name = "tabCola";
            tabCola.Size = new Size(1012, 172);
            tabCola.TabIndex = 1;
            tabCola.Text = "Cola";
            // 
            // BorrarReporteCola
            // 
            BorrarReporteCola.Location = new Point(832, 97);
            BorrarReporteCola.Name = "BorrarReporteCola";
            BorrarReporteCola.Size = new Size(75, 23);
            BorrarReporteCola.TabIndex = 2;
            BorrarReporteCola.Text = "Eliminar";
            BorrarReporteCola.UseVisualStyleBackColor = true;
            BorrarReporteCola.Click += BorrarReporteCola_Click;
            // 
            // reporteCola
            // 
            reporteCola.Location = new Point(832, 34);
            reporteCola.Name = "reporteCola";
            reporteCola.Size = new Size(75, 23);
            reporteCola.TabIndex = 1;
            reporteCola.Text = "Reporte";
            reporteCola.UseVisualStyleBackColor = true;
            reporteCola.Click += reporteCola_Click;
            // 
            // dataGridCola
            // 
            dataGridCola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCola.Location = new Point(4, 8);
            dataGridCola.Name = "dataGridCola";
            dataGridCola.Size = new Size(750, 150);
            dataGridCola.TabIndex = 0;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(eliminarLista);
            tabLista.Controls.Add(reporteLista);
            tabLista.Controls.Add(dataGridLista);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Size = new Size(1012, 172);
            tabLista.TabIndex = 2;
            tabLista.Text = "Lista";
            // 
            // eliminarLista
            // 
            eliminarLista.Location = new Point(869, 109);
            eliminarLista.Name = "eliminarLista";
            eliminarLista.Size = new Size(75, 23);
            eliminarLista.TabIndex = 2;
            eliminarLista.Text = "Eliminar";
            eliminarLista.UseVisualStyleBackColor = true;
            eliminarLista.Click += eliminarLista_Click;
            // 
            // reporteLista
            // 
            reporteLista.Location = new Point(869, 34);
            reporteLista.Name = "reporteLista";
            reporteLista.Size = new Size(75, 23);
            reporteLista.TabIndex = 1;
            reporteLista.Text = "Reporte";
            reporteLista.UseVisualStyleBackColor = true;
            reporteLista.Click += reporteLista_Click;
            // 
            // dataGridLista
            // 
            dataGridLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLista.Location = new Point(4, 6);
            dataGridLista.Name = "dataGridLista";
            dataGridLista.Size = new Size(814, 150);
            dataGridLista.TabIndex = 0;
            // 
            // FormularioAfiliado
            // 
            ClientSize = new Size(1046, 777);
            Controls.Add(titulo);
            Controls.Add(subtitulo);
            Controls.Add(groupBoxAfiliado);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormularioAfiliado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresos de datos";
            groupBoxAfiliado.ResumeLayout(false);
            groupBoxAfiliado.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPila.ResumeLayout(false);
            tabPila.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPila).EndInit();
            tabCola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCola).EndInit();
            tabLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label titulo;
        private Label subtitulo;
        private GroupBox groupBoxAfiliado;
        private Label lblTipoId;
        private ComboBox cbTipoId;
        private Label lblId;
        private TextBox txtId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblSalario;
        private TextBox txtSalario;
        private Label lblEstrato;
        private ComboBox cbEstrato;
        private Label lblSISBEN;
        private RadioButton rbSi;
        private RadioButton rbNo;
        private Label lblSubsidio;
        private TextBox txtSubsidio;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblTipoEstructura;
        private ComboBox cbTipoEstructura;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblCamposObligatorios;
        private TabControl tabControl;
        private TabPage tabPila;
        private TextBox txtReporte;
        private Button btnReporte;
        private Button btnEliminar;
        private TabPage tabCola;
        private TabPage tabLista;
        private Button reportePila;
        private Button borrarReportePila;
        private DataGridView dataGridPila;
        private Button BorrarReporteCola;
        private Button reporteCola;
        private DataGridView dataGridCola;
        private Button eliminarLista;
        private Button reporteLista;
        private DataGridView dataGridLista;
    }
}
