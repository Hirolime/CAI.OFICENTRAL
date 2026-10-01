namespace CAI.OFICENTRAL;

partial class ConfirmacionRecepcionForm1
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
        cboSolicitud = new ComboBox();
        lbl2 = new Label();
        cboEntrega = new ComboBox();
        lbl4 = new Label();
        dtpRecepcion = new DateTimePicker();
        lbl6 = new Label();
        txtEmpleado = new TextBox();
        lbl8 = new Label();
        txtEstado = new TextBox();
        lbl10 = new Label();
        dgvRecepcion = new DataGridView();
        lbl12 = new Label();
        lbl13 = new Label();
        numCantidad = new NumericUpDown();
        btnActualizarCantidad = new Button();
        chkConforme = new CheckBox();
        lbl17 = new Label();
        txtObservaciones = new TextBox();
        btnCancelar = new Button();
        btnConfirmar = new Button();
        dgvRecepcionCol0 = new DataGridViewTextBoxColumn();
        dgvRecepcionCol1 = new DataGridViewTextBoxColumn();
        dgvRecepcionCol2 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvRecepcion).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
        SuspendLayout();
        // lbl0
        lbl0.Location = new Point(24, 24);
        lbl0.Name = "lbl0";
        lbl0.Size = new Size(260, 22);
        lbl0.TabIndex = 0;
        lbl0.Text = "Solicitud N.º";
        lbl0.AutoSize = false;
        // cboSolicitud
        cboSolicitud.Location = new Point(24, 48);
        cboSolicitud.Name = "cboSolicitud";
        cboSolicitud.Size = new Size(264, 28);
        cboSolicitud.TabIndex = 1;
        cboSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSolicitud.FormattingEnabled = true;
        // lbl2
        lbl2.Location = new Point(312, 24);
        lbl2.Name = "lbl2";
        lbl2.Size = new Size(260, 22);
        lbl2.TabIndex = 2;
        lbl2.Text = "Entrega N.º";
        lbl2.AutoSize = false;
        // cboEntrega
        cboEntrega.Location = new Point(312, 48);
        cboEntrega.Name = "cboEntrega";
        cboEntrega.Size = new Size(264, 28);
        cboEntrega.TabIndex = 3;
        cboEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEntrega.FormattingEnabled = true;
        // lbl4
        lbl4.Location = new Point(600, 24);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(260, 22);
        lbl4.TabIndex = 4;
        lbl4.Text = "Fecha de recepción";
        lbl4.AutoSize = false;
        // dtpRecepcion
        dtpRecepcion.Location = new Point(600, 48);
        dtpRecepcion.Name = "dtpRecepcion";
        dtpRecepcion.Size = new Size(264, 28);
        dtpRecepcion.TabIndex = 5;
        dtpRecepcion.Format = DateTimePickerFormat.Short;
        // lbl6
        lbl6.Location = new Point(24, 96);
        lbl6.Name = "lbl6";
        lbl6.Size = new Size(260, 22);
        lbl6.TabIndex = 6;
        lbl6.Text = "Empleado solicitante";
        lbl6.AutoSize = false;
        // txtEmpleado
        txtEmpleado.Location = new Point(24, 120);
        txtEmpleado.Name = "txtEmpleado";
        txtEmpleado.Size = new Size(264, 28);
        txtEmpleado.TabIndex = 7;
        txtEmpleado.ReadOnly = true;
        txtEmpleado.TabStop = false;
        // lbl8
        lbl8.Location = new Point(312, 96);
        lbl8.Name = "lbl8";
        lbl8.Size = new Size(260, 22);
        lbl8.TabIndex = 8;
        lbl8.Text = "Estado";
        lbl8.AutoSize = false;
        // txtEstado
        txtEstado.Location = new Point(312, 120);
        txtEstado.Name = "txtEstado";
        txtEstado.Size = new Size(264, 28);
        txtEstado.TabIndex = 9;
        txtEstado.ReadOnly = true;
        txtEstado.TabStop = false;
        // lbl10
        lbl10.Location = new Point(24, 168);
        lbl10.Name = "lbl10";
        lbl10.Size = new Size(840, 22);
        lbl10.TabIndex = 10;
        lbl10.Text = "Materiales recibidos";
        lbl10.AutoSize = false;
        // dgvRecepcion
        dgvRecepcion.Location = new Point(24, 194);
        dgvRecepcion.Name = "dgvRecepcion";
        dgvRecepcion.Size = new Size(840, 160);
        dgvRecepcion.TabIndex = 11;
        dgvRecepcion.AllowUserToAddRows = false;
        dgvRecepcion.AllowUserToDeleteRows = false;
        dgvRecepcion.ReadOnly = true;
        dgvRecepcion.RowHeadersVisible = false;
        dgvRecepcion.MultiSelect = false;
        dgvRecepcion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRecepcion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvRecepcion.BackgroundColor = SystemColors.Window;
        dgvRecepcion.BorderStyle = BorderStyle.FixedSingle;
        dgvRecepcion.ColumnHeadersHeight = 32;
        dgvRecepcion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvRecepcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dgvRecepcion.Columns.AddRange(new DataGridViewColumn[] { dgvRecepcionCol0, dgvRecepcionCol1, dgvRecepcionCol2 });
        dgvRecepcionCol0.HeaderText = "Material";
        dgvRecepcionCol0.Name = "dgvRecepcionCol0";
        dgvRecepcionCol0.ReadOnly = true;
        dgvRecepcionCol1.HeaderText = "Entregado";
        dgvRecepcionCol1.Name = "dgvRecepcionCol1";
        dgvRecepcionCol1.ReadOnly = true;
        dgvRecepcionCol2.HeaderText = "Recibido";
        dgvRecepcionCol2.Name = "dgvRecepcionCol2";
        dgvRecepcionCol2.ReadOnly = true;
        // lbl12
        lbl12.Location = new Point(24, 366);
        lbl12.Name = "lbl12";
        lbl12.Size = new Size(840, 22);
        lbl12.TabIndex = 12;
        lbl12.Text = "Revisar ítem seleccionado";
        lbl12.AutoSize = false;
        // lbl13
        lbl13.Location = new Point(24, 394);
        lbl13.Name = "lbl13";
        lbl13.Size = new Size(260, 22);
        lbl13.TabIndex = 13;
        lbl13.Text = "Cantidad recibida";
        lbl13.AutoSize = false;
        // numCantidad
        numCantidad.Location = new Point(24, 418);
        numCantidad.Name = "numCantidad";
        numCantidad.Size = new Size(264, 28);
        numCantidad.TabIndex = 14;
        numCantidad.Maximum = 100000000M;
        numCantidad.ThousandsSeparator = true;
        // btnActualizarCantidad
        btnActualizarCantidad.Location = new Point(24, 466);
        btnActualizarCantidad.Name = "btnActualizarCantidad";
        btnActualizarCantidad.Size = new Size(178, 32);
        btnActualizarCantidad.TabIndex = 15;
        btnActualizarCantidad.Text = "Actualizar cantidad";
        btnActualizarCantidad.UseVisualStyleBackColor = true;
        // chkConforme
        chkConforme.Location = new Point(24, 516);
        chkConforme.Name = "chkConforme";
        chkConforme.Size = new Size(840, 28);
        chkConforme.TabIndex = 16;
        chkConforme.Text = "Recibí todos los materiales conforme";
        chkConforme.UseVisualStyleBackColor = true;
        // lbl17
        lbl17.Location = new Point(24, 558);
        lbl17.Name = "lbl17";
        lbl17.Size = new Size(840, 22);
        lbl17.TabIndex = 17;
        lbl17.Text = "Observaciones / faltantes";
        lbl17.AutoSize = false;
        // txtObservaciones
        txtObservaciones.Location = new Point(24, 582);
        txtObservaciones.Name = "txtObservaciones";
        txtObservaciones.Size = new Size(840, 66);
        txtObservaciones.TabIndex = 18;
        txtObservaciones.Multiline = true;
        txtObservaciones.ScrollBars = ScrollBars.Vertical;
        // btnCancelar
        btnCancelar.Location = new Point(754, 678);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(110, 34);
        btnCancelar.TabIndex = 19;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        // btnConfirmar
        btnConfirmar.Location = new Point(568, 678);
        btnConfirmar.Name = "btnConfirmar";
        btnConfirmar.Size = new Size(176, 34);
        btnConfirmar.TabIndex = 20;
        btnConfirmar.Text = "Confirmar recepción";
        btnConfirmar.UseVisualStyleBackColor = true;
        btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(888, 742);
        Controls.Add(lbl0);
        Controls.Add(cboSolicitud);
        Controls.Add(lbl2);
        Controls.Add(cboEntrega);
        Controls.Add(lbl4);
        Controls.Add(dtpRecepcion);
        Controls.Add(lbl6);
        Controls.Add(txtEmpleado);
        Controls.Add(lbl8);
        Controls.Add(txtEstado);
        Controls.Add(lbl10);
        Controls.Add(dgvRecepcion);
        Controls.Add(lbl12);
        Controls.Add(lbl13);
        Controls.Add(numCantidad);
        Controls.Add(btnActualizarCantidad);
        Controls.Add(chkConforme);
        Controls.Add(lbl17);
        Controls.Add(txtObservaciones);
        Controls.Add(btnCancelar);
        Controls.Add(btnConfirmar);
        MinimumSize = new Size(904, 781);
        Name = "FrmConfirmacionRecepcion";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Confirmación de recepción - OfiCentral S.A.";
        ((System.ComponentModel.ISupportInitialize)dgvRecepcion).EndInit();
        ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl0;
    private ComboBox cboSolicitud;
    private Label lbl2;
    private ComboBox cboEntrega;
    private Label lbl4;
    private DateTimePicker dtpRecepcion;
    private Label lbl6;
    private TextBox txtEmpleado;
    private Label lbl8;
    private TextBox txtEstado;
    private Label lbl10;
    private DataGridView dgvRecepcion;
    private Label lbl12;
    private Label lbl13;
    private NumericUpDown numCantidad;
    private Button btnActualizarCantidad;
    private CheckBox chkConforme;
    private Label lbl17;
    private TextBox txtObservaciones;
    private Button btnCancelar;
    private Button btnConfirmar;
    private DataGridViewTextBoxColumn dgvRecepcionCol0;
    private DataGridViewTextBoxColumn dgvRecepcionCol1;
    private DataGridViewTextBoxColumn dgvRecepcionCol2;
}

