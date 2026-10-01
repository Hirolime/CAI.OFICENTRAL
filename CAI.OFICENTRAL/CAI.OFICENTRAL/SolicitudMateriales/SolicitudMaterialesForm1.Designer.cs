namespace CAI.OFICENTRAL;

partial class SolicitudMaterialesForm1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lbl0 = new Label();
        txtSolicitud = new TextBox();
        lbl2 = new Label();
        dtpFecha = new DateTimePicker();
        lbl4 = new Label();
        txtEstado = new TextBox();
        lbl6 = new Label();
        cboEmpleado = new ComboBox();
        lbl8 = new Label();
        cboArea = new ComboBox();
        lbl10 = new Label();
        dtpFechaNecesaria = new DateTimePicker();
        lbl12 = new Label();
        lbl13 = new Label();
        cboMaterial = new ComboBox();
        lbl15 = new Label();
        numCantidad = new NumericUpDown();
        lbl17 = new Label();
        cboUnidad = new ComboBox();
        btnAgregarMaterial = new Button();
        lbl20 = new Label();
        dgvMateriales = new DataGridView();
        btnModificar = new Button();
        btnQuitar = new Button();
        lbl24 = new Label();
        txtMotivo = new TextBox();
        btnCancelar = new Button();
        btnEnviar = new Button();
        dgvMaterialesCol0 = new DataGridViewTextBoxColumn();
        dgvMaterialesCol1 = new DataGridViewTextBoxColumn();
        dgvMaterialesCol2 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvMateriales).BeginInit();
        SuspendLayout();
        // lbl0
        lbl0.Location = new Point(24, 24);
        lbl0.Name = "lbl0";
        lbl0.Size = new Size(260, 22);
        lbl0.TabIndex = 0;
        lbl0.Text = "Solicitud N.º";
        lbl0.AutoSize = false;
        // txtSolicitud
        txtSolicitud.Location = new Point(24, 48);
        txtSolicitud.Name = "txtSolicitud";
        txtSolicitud.Size = new Size(264, 28);
        txtSolicitud.TabIndex = 1;
        txtSolicitud.ReadOnly = true;
        txtSolicitud.TabStop = false;
        // lbl2
        lbl2.Location = new Point(312, 24);
        lbl2.Name = "lbl2";
        lbl2.Size = new Size(260, 22);
        lbl2.TabIndex = 2;
        lbl2.Text = "Fecha";
        lbl2.AutoSize = false;
        // dtpFecha
        dtpFecha.Location = new Point(312, 48);
        dtpFecha.Name = "dtpFecha";
        dtpFecha.Size = new Size(264, 28);
        dtpFecha.TabIndex = 3;
        dtpFecha.Format = DateTimePickerFormat.Short;
        // lbl4
        lbl4.Location = new Point(600, 24);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(260, 22);
        lbl4.TabIndex = 4;
        lbl4.Text = "Estado";
        lbl4.AutoSize = false;
        // txtEstado
        txtEstado.Location = new Point(600, 48);
        txtEstado.Name = "txtEstado";
        txtEstado.Size = new Size(264, 28);
        txtEstado.TabIndex = 5;
        txtEstado.ReadOnly = true;
        txtEstado.TabStop = false;
        // lbl6
        lbl6.Location = new Point(24, 96);
        lbl6.Name = "lbl6";
        lbl6.Size = new Size(260, 22);
        lbl6.TabIndex = 6;
        lbl6.Text = "Empleado solicitante";
        lbl6.AutoSize = false;
        // cboEmpleado
        cboEmpleado.Location = new Point(24, 120);
        cboEmpleado.Name = "cboEmpleado";
        cboEmpleado.Size = new Size(264, 28);
        cboEmpleado.TabIndex = 7;
        cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEmpleado.FormattingEnabled = true;
        // lbl8
        lbl8.Location = new Point(312, 96);
        lbl8.Name = "lbl8";
        lbl8.Size = new Size(260, 22);
        lbl8.TabIndex = 8;
        lbl8.Text = "Área";
        lbl8.AutoSize = false;
        // cboArea
        cboArea.Location = new Point(312, 120);
        cboArea.Name = "cboArea";
        cboArea.Size = new Size(264, 28);
        cboArea.TabIndex = 9;
        cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
        cboArea.FormattingEnabled = true;
        // lbl10
        lbl10.Location = new Point(600, 96);
        lbl10.Name = "lbl10";
        lbl10.Size = new Size(260, 22);
        lbl10.TabIndex = 10;
        lbl10.Text = "Fecha necesaria";
        lbl10.AutoSize = false;
        // dtpFechaNecesaria
        dtpFechaNecesaria.Location = new Point(600, 120);
        dtpFechaNecesaria.Name = "dtpFechaNecesaria";
        dtpFechaNecesaria.Size = new Size(264, 28);
        dtpFechaNecesaria.TabIndex = 11;
        dtpFechaNecesaria.Format = DateTimePickerFormat.Short;
        // lbl12
        lbl12.Location = new Point(24, 168);
        lbl12.Name = "lbl12";
        lbl12.Size = new Size(840, 22);
        lbl12.TabIndex = 12;
        lbl12.Text = "Agregar material";
        lbl12.AutoSize = false;
        // lbl13
        lbl13.Location = new Point(24, 196);
        lbl13.Name = "lbl13";
        lbl13.Size = new Size(260, 22);
        lbl13.TabIndex = 13;
        lbl13.Text = "Material";
        lbl13.AutoSize = false;
        // cboMaterial
        cboMaterial.Location = new Point(24, 220);
        cboMaterial.Name = "cboMaterial";
        cboMaterial.Size = new Size(264, 28);
        cboMaterial.TabIndex = 14;
        cboMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
        cboMaterial.FormattingEnabled = true;
        cboMaterial.Items.AddRange(new object[] { "Tijeras", "Lápices", "Cuadernos", "Biromes" });
        // lbl15
        lbl15.Location = new Point(312, 196);
        lbl15.Name = "lbl15";
        lbl15.Size = new Size(260, 22);
        lbl15.TabIndex = 15;
        lbl15.Text = "Cantidad";
        lbl15.AutoSize = false;
        // numCantidad
        numCantidad.Location = new Point(312, 220);
        numCantidad.Name = "numCantidad";
        numCantidad.Size = new Size(264, 28);
        numCantidad.TabIndex = 16;
        numCantidad.Maximum = 100000000M;
        numCantidad.ThousandsSeparator = true;
        // lbl17
        lbl17.Location = new Point(600, 196);
        lbl17.Name = "lbl17";
        lbl17.Size = new Size(260, 22);
        lbl17.TabIndex = 17;
        lbl17.Text = "Unidad";
        lbl17.AutoSize = false;
        // cboUnidad
        cboUnidad.Location = new Point(600, 220);
        cboUnidad.Name = "cboUnidad";
        cboUnidad.Size = new Size(264, 28);
        cboUnidad.TabIndex = 18;
        cboUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
        cboUnidad.FormattingEnabled = true;
        cboUnidad.Items.AddRange(new object[] { "Unidad", "Caja", "Paquete" });
        // btnAgregarMaterial
        btnAgregarMaterial.Location = new Point(24, 268);
        btnAgregarMaterial.Name = "btnAgregarMaterial";
        btnAgregarMaterial.Size = new Size(154, 32);
        btnAgregarMaterial.TabIndex = 19;
        btnAgregarMaterial.Text = "Agregar material";
        btnAgregarMaterial.UseVisualStyleBackColor = true;
        // lbl20
        lbl20.Location = new Point(24, 318);
        lbl20.Name = "lbl20";
        lbl20.Size = new Size(840, 22);
        lbl20.TabIndex = 20;
        lbl20.Text = "Materiales solicitados";
        lbl20.AutoSize = false;
        // dgvMateriales
        dgvMateriales.Location = new Point(24, 344);
        dgvMateriales.Name = "dgvMateriales";
        dgvMateriales.Size = new Size(840, 132);
        dgvMateriales.TabIndex = 21;
        dgvMateriales.AllowUserToAddRows = false;
        dgvMateriales.AllowUserToDeleteRows = false;
        dgvMateriales.ReadOnly = true;
        dgvMateriales.RowHeadersVisible = false;
        dgvMateriales.MultiSelect = false;
        dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvMateriales.BackgroundColor = SystemColors.Window;
        dgvMateriales.BorderStyle = BorderStyle.FixedSingle;
        dgvMateriales.ColumnHeadersHeight = 32;
        dgvMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvMateriales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dgvMateriales.Columns.AddRange(new DataGridViewColumn[] { dgvMaterialesCol0, dgvMaterialesCol1, dgvMaterialesCol2 });
        dgvMaterialesCol0.HeaderText = "Material";
        dgvMaterialesCol0.Name = "dgvMaterialesCol0";
        dgvMaterialesCol0.ReadOnly = true;
        dgvMaterialesCol1.HeaderText = "Cantidad";
        dgvMaterialesCol1.Name = "dgvMaterialesCol1";
        dgvMaterialesCol1.ReadOnly = true;
        dgvMaterialesCol2.HeaderText = "Unidad";
        dgvMaterialesCol2.Name = "dgvMaterialesCol2";
        dgvMaterialesCol2.ReadOnly = true;
        // btnModificar
        btnModificar.Location = new Point(24, 488);
        btnModificar.Name = "btnModificar";
        btnModificar.Size = new Size(202, 32);
        btnModificar.TabIndex = 22;
        btnModificar.Text = "Modificar seleccionado";
        btnModificar.UseVisualStyleBackColor = true;
        // btnQuitar
        btnQuitar.Location = new Point(236, 488);
        btnQuitar.Name = "btnQuitar";
        btnQuitar.Size = new Size(178, 32);
        btnQuitar.TabIndex = 23;
        btnQuitar.Text = "Quitar seleccionado";
        btnQuitar.UseVisualStyleBackColor = true;
        // lbl24
        lbl24.Location = new Point(24, 538);
        lbl24.Name = "lbl24";
        lbl24.Size = new Size(840, 22);
        lbl24.TabIndex = 24;
        lbl24.Text = "Motivo de la solicitud";
        lbl24.AutoSize = false;
        // txtMotivo
        txtMotivo.Location = new Point(24, 562);
        txtMotivo.Name = "txtMotivo";
        txtMotivo.Size = new Size(840, 66);
        txtMotivo.TabIndex = 25;
        txtMotivo.Multiline = true;
        txtMotivo.ScrollBars = ScrollBars.Vertical;
        // btnCancelar
        btnCancelar.Location = new Point(754, 658);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(110, 34);
        btnCancelar.TabIndex = 26;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        // btnEnviar
        btnEnviar.Location = new Point(592, 658);
        btnEnviar.Name = "btnEnviar";
        btnEnviar.Size = new Size(152, 34);
        btnEnviar.TabIndex = 27;
        btnEnviar.Text = "Enviar solicitud";
        btnEnviar.UseVisualStyleBackColor = true;
        btnEnviar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(888, 722);
        Controls.Add(lbl0);
        Controls.Add(txtSolicitud);
        Controls.Add(lbl2);
        Controls.Add(dtpFecha);
        Controls.Add(lbl4);
        Controls.Add(txtEstado);
        Controls.Add(lbl6);
        Controls.Add(cboEmpleado);
        Controls.Add(lbl8);
        Controls.Add(cboArea);
        Controls.Add(lbl10);
        Controls.Add(dtpFechaNecesaria);
        Controls.Add(lbl12);
        Controls.Add(lbl13);
        Controls.Add(cboMaterial);
        Controls.Add(lbl15);
        Controls.Add(numCantidad);
        Controls.Add(lbl17);
        Controls.Add(cboUnidad);
        Controls.Add(btnAgregarMaterial);
        Controls.Add(lbl20);
        Controls.Add(dgvMateriales);
        Controls.Add(btnModificar);
        Controls.Add(btnQuitar);
        Controls.Add(lbl24);
        Controls.Add(txtMotivo);
        Controls.Add(btnCancelar);
        Controls.Add(btnEnviar);
        MinimumSize = new Size(904, 761);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Nueva solicitud de materiales - OfiCentral S.A.";
        ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvMateriales).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl0;
    private TextBox txtSolicitud;
    private Label lbl2;
    private DateTimePicker dtpFecha;
    private Label lbl4;
    private TextBox txtEstado;
    private Label lbl6;
    private ComboBox cboEmpleado;
    private Label lbl8;
    private ComboBox cboArea;
    private Label lbl10;
    private DateTimePicker dtpFechaNecesaria;
    private Label lbl12;
    private Label lbl13;
    private ComboBox cboMaterial;
    private Label lbl15;
    private NumericUpDown numCantidad;
    private Label lbl17;
    private ComboBox cboUnidad;
    private Button btnAgregarMaterial;
    private Label lbl20;
    private DataGridView dgvMateriales;
    private Button btnModificar;
    private Button btnQuitar;
    private Label lbl24;
    private TextBox txtMotivo;
    private Button btnCancelar;
    private Button btnEnviar;
    private DataGridViewTextBoxColumn dgvMaterialesCol0;
    private DataGridViewTextBoxColumn dgvMaterialesCol1;
    private DataGridViewTextBoxColumn dgvMaterialesCol2;
}

