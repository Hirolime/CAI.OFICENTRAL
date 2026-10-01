namespace CAI.OFICENTRAL;

partial class OrdenCompraForm1
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
        txtOrden = new TextBox();
        lbl2 = new Label();
        dtpFecha = new DateTimePicker();
        lbl4 = new Label();
        cboSolicitud = new ComboBox();
        lbl6 = new Label();
        cboProveedor = new ComboBox();
        lbl8 = new Label();
        dtpPrevista = new DateTimePicker();
        lbl10 = new Label();
        txtEstado = new TextBox();
        lbl12 = new Label();
        dgvMateriales = new DataGridView();
        lbl14 = new Label();
        lbl15 = new Label();
        numCantidad = new NumericUpDown();
        lbl17 = new Label();
        numPrecio = new NumericUpDown();
        btnActualizarItem = new Button();
        lbl20 = new Label();
        txtTotal = new TextBox();
        lbl22 = new Label();
        cboPago = new ComboBox();
        lbl24 = new Label();
        txtObservaciones = new TextBox();
        btnCancelar = new Button();
        btnGenerar = new Button();
        dgvMaterialesCol0 = new DataGridViewTextBoxColumn();
        dgvMaterialesCol1 = new DataGridViewTextBoxColumn();
        dgvMaterialesCol2 = new DataGridViewTextBoxColumn();
        dgvMaterialesCol3 = new DataGridViewTextBoxColumn();
        dgvMaterialesCol4 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvMateriales).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
        SuspendLayout();
        // lbl0
        lbl0.Location = new Point(24, 24);
        lbl0.Name = "lbl0";
        lbl0.Size = new Size(260, 22);
        lbl0.TabIndex = 0;
        lbl0.Text = "Orden N.º";
        lbl0.AutoSize = false;
        // txtOrden
        txtOrden.Location = new Point(24, 48);
        txtOrden.Name = "txtOrden";
        txtOrden.Size = new Size(264, 28);
        txtOrden.TabIndex = 1;
        txtOrden.ReadOnly = true;
        txtOrden.TabStop = false;
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
        lbl4.Text = "Solicitud aprobada";
        lbl4.AutoSize = false;
        // cboSolicitud
        cboSolicitud.Location = new Point(600, 48);
        cboSolicitud.Name = "cboSolicitud";
        cboSolicitud.Size = new Size(264, 28);
        cboSolicitud.TabIndex = 5;
        cboSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSolicitud.FormattingEnabled = true;
        // lbl6
        lbl6.Location = new Point(24, 96);
        lbl6.Name = "lbl6";
        lbl6.Size = new Size(260, 22);
        lbl6.TabIndex = 6;
        lbl6.Text = "Proveedor";
        lbl6.AutoSize = false;
        // cboProveedor
        cboProveedor.Location = new Point(24, 120);
        cboProveedor.Name = "cboProveedor";
        cboProveedor.Size = new Size(264, 28);
        cboProveedor.TabIndex = 7;
        cboProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        cboProveedor.FormattingEnabled = true;
        // lbl8
        lbl8.Location = new Point(312, 96);
        lbl8.Name = "lbl8";
        lbl8.Size = new Size(260, 22);
        lbl8.TabIndex = 8;
        lbl8.Text = "Fecha prevista";
        lbl8.AutoSize = false;
        // dtpPrevista
        dtpPrevista.Location = new Point(312, 120);
        dtpPrevista.Name = "dtpPrevista";
        dtpPrevista.Size = new Size(264, 28);
        dtpPrevista.TabIndex = 9;
        dtpPrevista.Format = DateTimePickerFormat.Short;
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
        lbl12.Text = "Materiales a comprar";
        lbl12.AutoSize = false;
        // dgvMateriales
        dgvMateriales.Location = new Point(24, 194);
        dgvMateriales.Name = "dgvMateriales";
        dgvMateriales.Size = new Size(840, 132);
        dgvMateriales.TabIndex = 13;
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
        dgvMateriales.Columns.AddRange(new DataGridViewColumn[] { dgvMaterialesCol0, dgvMaterialesCol1, dgvMaterialesCol2, dgvMaterialesCol3, dgvMaterialesCol4 });
        dgvMaterialesCol0.HeaderText = "Material";
        dgvMaterialesCol0.Name = "dgvMaterialesCol0";
        dgvMaterialesCol0.ReadOnly = true;
        dgvMaterialesCol1.HeaderText = "Cantidad";
        dgvMaterialesCol1.Name = "dgvMaterialesCol1";
        dgvMaterialesCol1.ReadOnly = true;
        dgvMaterialesCol2.HeaderText = "Unidad";
        dgvMaterialesCol2.Name = "dgvMaterialesCol2";
        dgvMaterialesCol2.ReadOnly = true;
        dgvMaterialesCol3.HeaderText = "Precio unitario";
        dgvMaterialesCol3.Name = "dgvMaterialesCol3";
        dgvMaterialesCol3.ReadOnly = true;
        dgvMaterialesCol4.HeaderText = "Importe";
        dgvMaterialesCol4.Name = "dgvMaterialesCol4";
        dgvMaterialesCol4.ReadOnly = true;
        // lbl14
        lbl14.Location = new Point(24, 338);
        lbl14.Name = "lbl14";
        lbl14.Size = new Size(840, 22);
        lbl14.TabIndex = 14;
        lbl14.Text = "Editar ítem seleccionado";
        lbl14.AutoSize = false;
        // lbl15
        lbl15.Location = new Point(24, 366);
        lbl15.Name = "lbl15";
        lbl15.Size = new Size(260, 22);
        lbl15.TabIndex = 15;
        lbl15.Text = "Cantidad";
        lbl15.AutoSize = false;
        // numCantidad
        numCantidad.Location = new Point(24, 390);
        numCantidad.Name = "numCantidad";
        numCantidad.Size = new Size(264, 28);
        numCantidad.TabIndex = 16;
        numCantidad.Maximum = 100000000M;
        numCantidad.ThousandsSeparator = true;
        // lbl17
        lbl17.Location = new Point(312, 366);
        lbl17.Name = "lbl17";
        lbl17.Size = new Size(260, 22);
        lbl17.TabIndex = 17;
        lbl17.Text = "Precio unitario";
        lbl17.AutoSize = false;
        // numPrecio
        numPrecio.Location = new Point(312, 390);
        numPrecio.Name = "numPrecio";
        numPrecio.Size = new Size(264, 28);
        numPrecio.TabIndex = 18;
        numPrecio.Maximum = 100000000M;
        numPrecio.ThousandsSeparator = true;
        numPrecio.DecimalPlaces = 2;
        // btnActualizarItem
        btnActualizarItem.Location = new Point(24, 438);
        btnActualizarItem.Name = "btnActualizarItem";
        btnActualizarItem.Size = new Size(146, 32);
        btnActualizarItem.TabIndex = 19;
        btnActualizarItem.Text = "Actualizar ítem";
        btnActualizarItem.UseVisualStyleBackColor = true;
        // lbl20
        lbl20.Location = new Point(24, 488);
        lbl20.Name = "lbl20";
        lbl20.Size = new Size(260, 22);
        lbl20.TabIndex = 20;
        lbl20.Text = "Total de la orden";
        lbl20.AutoSize = false;
        // txtTotal
        txtTotal.Location = new Point(24, 512);
        txtTotal.Name = "txtTotal";
        txtTotal.Size = new Size(264, 28);
        txtTotal.TabIndex = 21;
        txtTotal.ReadOnly = true;
        txtTotal.TabStop = false;
        // lbl22
        lbl22.Location = new Point(312, 488);
        lbl22.Name = "lbl22";
        lbl22.Size = new Size(260, 22);
        lbl22.TabIndex = 22;
        lbl22.Text = "Condición de pago";
        lbl22.AutoSize = false;
        // cboPago
        cboPago.Location = new Point(312, 512);
        cboPago.Name = "cboPago";
        cboPago.Size = new Size(264, 28);
        cboPago.TabIndex = 23;
        cboPago.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPago.FormattingEnabled = true;
        cboPago.Items.AddRange(new object[] { "Contado", "Cuenta corriente" });
        // lbl24
        lbl24.Location = new Point(24, 560);
        lbl24.Name = "lbl24";
        lbl24.Size = new Size(840, 22);
        lbl24.TabIndex = 24;
        lbl24.Text = "Observaciones";
        lbl24.AutoSize = false;
        // txtObservaciones
        txtObservaciones.Location = new Point(24, 584);
        txtObservaciones.Name = "txtObservaciones";
        txtObservaciones.Size = new Size(840, 66);
        txtObservaciones.TabIndex = 25;
        txtObservaciones.Multiline = true;
        txtObservaciones.ScrollBars = ScrollBars.Vertical;
        // btnCancelar
        btnCancelar.Location = new Point(754, 680);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(110, 34);
        btnCancelar.TabIndex = 26;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        // btnGenerar
        btnGenerar.Location = new Point(616, 680);
        btnGenerar.Name = "btnGenerar";
        btnGenerar.Size = new Size(128, 34);
        btnGenerar.TabIndex = 27;
        btnGenerar.Text = "Generar orden";
        btnGenerar.UseVisualStyleBackColor = true;
        btnGenerar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(888, 744);
        Controls.Add(lbl0);
        Controls.Add(txtOrden);
        Controls.Add(lbl2);
        Controls.Add(dtpFecha);
        Controls.Add(lbl4);
        Controls.Add(cboSolicitud);
        Controls.Add(lbl6);
        Controls.Add(cboProveedor);
        Controls.Add(lbl8);
        Controls.Add(dtpPrevista);
        Controls.Add(lbl10);
        Controls.Add(txtEstado);
        Controls.Add(lbl12);
        Controls.Add(dgvMateriales);
        Controls.Add(lbl14);
        Controls.Add(lbl15);
        Controls.Add(numCantidad);
        Controls.Add(lbl17);
        Controls.Add(numPrecio);
        Controls.Add(btnActualizarItem);
        Controls.Add(lbl20);
        Controls.Add(txtTotal);
        Controls.Add(lbl22);
        Controls.Add(cboPago);
        Controls.Add(lbl24);
        Controls.Add(txtObservaciones);
        Controls.Add(btnCancelar);
        Controls.Add(btnGenerar);
        MinimumSize = new Size(904, 783);
        Name = "FrmOrdenCompra";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Orden de compra - OfiCentral S.A.";
        ((System.ComponentModel.ISupportInitialize)dgvMateriales).EndInit();
        ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
        ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl0;
    private TextBox txtOrden;
    private Label lbl2;
    private DateTimePicker dtpFecha;
    private Label lbl4;
    private ComboBox cboSolicitud;
    private Label lbl6;
    private ComboBox cboProveedor;
    private Label lbl8;
    private DateTimePicker dtpPrevista;
    private Label lbl10;
    private TextBox txtEstado;
    private Label lbl12;
    private DataGridView dgvMateriales;
    private Label lbl14;
    private Label lbl15;
    private NumericUpDown numCantidad;
    private Label lbl17;
    private NumericUpDown numPrecio;
    private Button btnActualizarItem;
    private Label lbl20;
    private TextBox txtTotal;
    private Label lbl22;
    private ComboBox cboPago;
    private Label lbl24;
    private TextBox txtObservaciones;
    private Button btnCancelar;
    private Button btnGenerar;
    private DataGridViewTextBoxColumn dgvMaterialesCol0;
    private DataGridViewTextBoxColumn dgvMaterialesCol1;
    private DataGridViewTextBoxColumn dgvMaterialesCol2;
    private DataGridViewTextBoxColumn dgvMaterialesCol3;
    private DataGridViewTextBoxColumn dgvMaterialesCol4;
}

