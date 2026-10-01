namespace CAI.OFICENTRAL;

partial class EntregaMaterialesForm1
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
        txtOrden = new TextBox();
        lbl4 = new Label();
        txtSolicitante = new TextBox();
        lbl6 = new Label();
        dtpEntrega = new DateTimePicker();
        lbl8 = new Label();
        cboResponsable = new ComboBox();
        lbl10 = new Label();
        txtEstado = new TextBox();
        lbl12 = new Label();
        dgvEntrega = new DataGridView();
        lbl14 = new Label();
        lbl15 = new Label();
        numCantidad = new NumericUpDown();
        btnActualizarCantidad = new Button();
        lbl18 = new Label();
        txtObservaciones = new TextBox();
        btnCancelar = new Button();
        btnRegistrar = new Button();
        dgvEntregaCol0 = new DataGridViewTextBoxColumn();
        dgvEntregaCol1 = new DataGridViewTextBoxColumn();
        dgvEntregaCol2 = new DataGridViewTextBoxColumn();
        dgvEntregaCol3 = new DataGridViewTextBoxColumn();
        dgvEntregaCol4 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvEntrega).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
        SuspendLayout();
        // lbl0
        lbl0.Location = new Point(24, 24);
        lbl0.Name = "lbl0";
        lbl0.Size = new Size(260, 22);
        lbl0.TabIndex = 0;
        lbl0.Text = "Solicitud aprobada";
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
        lbl2.Text = "Orden de compra";
        lbl2.AutoSize = false;
        // txtOrden
        txtOrden.Location = new Point(312, 48);
        txtOrden.Name = "txtOrden";
        txtOrden.Size = new Size(264, 28);
        txtOrden.TabIndex = 3;
        txtOrden.ReadOnly = true;
        txtOrden.TabStop = false;
        // lbl4
        lbl4.Location = new Point(600, 24);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(260, 22);
        lbl4.TabIndex = 4;
        lbl4.Text = "Solicitante";
        lbl4.AutoSize = false;
        // txtSolicitante
        txtSolicitante.Location = new Point(600, 48);
        txtSolicitante.Name = "txtSolicitante";
        txtSolicitante.Size = new Size(264, 28);
        txtSolicitante.TabIndex = 5;
        txtSolicitante.ReadOnly = true;
        txtSolicitante.TabStop = false;
        // lbl6
        lbl6.Location = new Point(24, 96);
        lbl6.Name = "lbl6";
        lbl6.Size = new Size(260, 22);
        lbl6.TabIndex = 6;
        lbl6.Text = "Fecha de entrega";
        lbl6.AutoSize = false;
        // dtpEntrega
        dtpEntrega.Location = new Point(24, 120);
        dtpEntrega.Name = "dtpEntrega";
        dtpEntrega.Size = new Size(264, 28);
        dtpEntrega.TabIndex = 7;
        dtpEntrega.Format = DateTimePickerFormat.Short;
        // lbl8
        lbl8.Location = new Point(312, 96);
        lbl8.Name = "lbl8";
        lbl8.Size = new Size(260, 22);
        lbl8.TabIndex = 8;
        lbl8.Text = "Responsable de depósito";
        lbl8.AutoSize = false;
        // cboResponsable
        cboResponsable.Location = new Point(312, 120);
        cboResponsable.Name = "cboResponsable";
        cboResponsable.Size = new Size(264, 28);
        cboResponsable.TabIndex = 9;
        cboResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
        cboResponsable.FormattingEnabled = true;
        // lbl10
        lbl10.Location = new Point(600, 96);
        lbl10.Name = "lbl10";
        lbl10.Size = new Size(260, 22);
        lbl10.TabIndex = 10;
        lbl10.Text = "Estado";
        lbl10.AutoSize = false;
        // txtEstado
        txtEstado.Location = new Point(600, 120);
        txtEstado.Name = "txtEstado";
        txtEstado.Size = new Size(264, 28);
        txtEstado.TabIndex = 11;
        txtEstado.ReadOnly = true;
        txtEstado.TabStop = false;
        // lbl12
        lbl12.Location = new Point(24, 168);
        lbl12.Name = "lbl12";
        lbl12.Size = new Size(840, 22);
        lbl12.TabIndex = 12;
        lbl12.Text = "Detalle de entrega";
        lbl12.AutoSize = false;
        // dgvEntrega
        dgvEntrega.Location = new Point(24, 194);
        dgvEntrega.Name = "dgvEntrega";
        dgvEntrega.Size = new Size(840, 160);
        dgvEntrega.TabIndex = 13;
        dgvEntrega.AllowUserToAddRows = false;
        dgvEntrega.AllowUserToDeleteRows = false;
        dgvEntrega.ReadOnly = true;
        dgvEntrega.RowHeadersVisible = false;
        dgvEntrega.MultiSelect = false;
        dgvEntrega.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEntrega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEntrega.BackgroundColor = SystemColors.Window;
        dgvEntrega.BorderStyle = BorderStyle.FixedSingle;
        dgvEntrega.ColumnHeadersHeight = 32;
        dgvEntrega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dgvEntrega.Columns.AddRange(new DataGridViewColumn[] { dgvEntregaCol0, dgvEntregaCol1, dgvEntregaCol2, dgvEntregaCol3, dgvEntregaCol4 });
        dgvEntregaCol0.HeaderText = "Material";
        dgvEntregaCol0.Name = "dgvEntregaCol0";
        dgvEntregaCol0.ReadOnly = true;
        dgvEntregaCol1.HeaderText = "Solicitado";
        dgvEntregaCol1.Name = "dgvEntregaCol1";
        dgvEntregaCol1.ReadOnly = true;
        dgvEntregaCol2.HeaderText = "Entregado antes";
        dgvEntregaCol2.Name = "dgvEntregaCol2";
        dgvEntregaCol2.ReadOnly = true;
        dgvEntregaCol3.HeaderText = "Pendiente";
        dgvEntregaCol3.Name = "dgvEntregaCol3";
        dgvEntregaCol3.ReadOnly = true;
        dgvEntregaCol4.HeaderText = "A entregar";
        dgvEntregaCol4.Name = "dgvEntregaCol4";
        dgvEntregaCol4.ReadOnly = true;
        // lbl14
        lbl14.Location = new Point(24, 366);
        lbl14.Name = "lbl14";
        lbl14.Size = new Size(840, 22);
        lbl14.TabIndex = 14;
        lbl14.Text = "Preparar ítem seleccionado";
        lbl14.AutoSize = false;
        // lbl15
        lbl15.Location = new Point(24, 394);
        lbl15.Name = "lbl15";
        lbl15.Size = new Size(260, 22);
        lbl15.TabIndex = 15;
        lbl15.Text = "Cantidad a entregar";
        lbl15.AutoSize = false;
        // numCantidad
        numCantidad.Location = new Point(24, 418);
        numCantidad.Name = "numCantidad";
        numCantidad.Size = new Size(264, 28);
        numCantidad.TabIndex = 16;
        numCantidad.Maximum = 100000000M;
        numCantidad.ThousandsSeparator = true;
        // btnActualizarCantidad
        btnActualizarCantidad.Location = new Point(24, 466);
        btnActualizarCantidad.Name = "btnActualizarCantidad";
        btnActualizarCantidad.Size = new Size(178, 32);
        btnActualizarCantidad.TabIndex = 17;
        btnActualizarCantidad.Text = "Actualizar cantidad";
        btnActualizarCantidad.UseVisualStyleBackColor = true;
        // lbl18
        lbl18.Location = new Point(24, 516);
        lbl18.Name = "lbl18";
        lbl18.Size = new Size(840, 22);
        lbl18.TabIndex = 18;
        lbl18.Text = "Observaciones de entrega";
        lbl18.AutoSize = false;
        // txtObservaciones
        txtObservaciones.Location = new Point(24, 540);
        txtObservaciones.Name = "txtObservaciones";
        txtObservaciones.Size = new Size(840, 66);
        txtObservaciones.TabIndex = 19;
        txtObservaciones.Multiline = true;
        txtObservaciones.ScrollBars = ScrollBars.Vertical;
        // btnCancelar
        btnCancelar.Location = new Point(754, 636);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(110, 34);
        btnCancelar.TabIndex = 20;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        // btnRegistrar
        btnRegistrar.Location = new Point(584, 636);
        btnRegistrar.Name = "btnRegistrar";
        btnRegistrar.Size = new Size(160, 34);
        btnRegistrar.TabIndex = 21;
        btnRegistrar.Text = "Registrar entrega";
        btnRegistrar.UseVisualStyleBackColor = true;
        btnRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(888, 700);
        Controls.Add(lbl0);
        Controls.Add(cboSolicitud);
        Controls.Add(lbl2);
        Controls.Add(txtOrden);
        Controls.Add(lbl4);
        Controls.Add(txtSolicitante);
        Controls.Add(lbl6);
        Controls.Add(dtpEntrega);
        Controls.Add(lbl8);
        Controls.Add(cboResponsable);
        Controls.Add(lbl10);
        Controls.Add(txtEstado);
        Controls.Add(lbl12);
        Controls.Add(dgvEntrega);
        Controls.Add(lbl14);
        Controls.Add(lbl15);
        Controls.Add(numCantidad);
        Controls.Add(btnActualizarCantidad);
        Controls.Add(lbl18);
        Controls.Add(txtObservaciones);
        Controls.Add(btnCancelar);
        Controls.Add(btnRegistrar);
        MinimumSize = new Size(904, 739);
        Name = "FrmEntregaMateriales";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Entrega de materiales - OfiCentral S.A.";
        ((System.ComponentModel.ISupportInitialize)dgvEntrega).EndInit();
        ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl0;
    private ComboBox cboSolicitud;
    private Label lbl2;
    private TextBox txtOrden;
    private Label lbl4;
    private TextBox txtSolicitante;
    private Label lbl6;
    private DateTimePicker dtpEntrega;
    private Label lbl8;
    private ComboBox cboResponsable;
    private Label lbl10;
    private TextBox txtEstado;
    private Label lbl12;
    private DataGridView dgvEntrega;
    private Label lbl14;
    private Label lbl15;
    private NumericUpDown numCantidad;
    private Button btnActualizarCantidad;
    private Label lbl18;
    private TextBox txtObservaciones;
    private Button btnCancelar;
    private Button btnRegistrar;
    private DataGridViewTextBoxColumn dgvEntregaCol0;
    private DataGridViewTextBoxColumn dgvEntregaCol1;
    private DataGridViewTextBoxColumn dgvEntregaCol2;
    private DataGridViewTextBoxColumn dgvEntregaCol3;
    private DataGridViewTextBoxColumn dgvEntregaCol4;
}

