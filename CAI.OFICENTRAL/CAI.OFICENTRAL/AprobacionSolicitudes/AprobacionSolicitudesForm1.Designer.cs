namespace CAI.OFICENTRAL.AprobacionSolicitudes
{
    partial class AprobacionSolicitudesForm1
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
            lbl0 = new Label();
            cboArea = new ComboBox();
            lbl2 = new Label();
            cboEstado = new ComboBox();
            lbl4 = new Label();
            dtpDesde = new DateTimePicker();
            btnCancelar = new Button();
            btnRechazar = new Button();
            btnAprobar = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnBuscar = new Button();
            lbl7 = new Label();
            dgvSolicitudes = new DataGridView();
            dgvSolicitudesCol0 = new DataGridViewTextBoxColumn();
            dgvSolicitudesCol1 = new DataGridViewTextBoxColumn();
            dgvSolicitudesCol2 = new DataGridViewTextBoxColumn();
            dgvSolicitudesCol3 = new DataGridViewTextBoxColumn();
            dgvSolicitudesCol4 = new DataGridViewTextBoxColumn();
            btnVerSolicitud = new Button();
            lbl10 = new Label();
            dgvDetalle = new DataGridView();
            dgvDetalleCol0 = new DataGridViewTextBoxColumn();
            dgvDetalleCol1 = new DataGridViewTextBoxColumn();
            dgvDetalleCol2 = new DataGridViewTextBoxColumn();
            lbl12 = new Label();
            txtObservaciones = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // lbl0
            // 
            lbl0.Location = new Point(-20, -108);
            lbl0.Name = "lbl0";
            lbl0.Size = new Size(260, 22);
            lbl0.TabIndex = 17;
            lbl0.Text = "Área";
            // 
            // cboArea
            // 
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.FormattingEnabled = true;
            cboArea.Location = new Point(-20, -84);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(264, 23);
            cboArea.TabIndex = 18;
            // 
            // lbl2
            // 
            lbl2.Location = new Point(268, -108);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(260, 22);
            lbl2.TabIndex = 19;
            lbl2.Text = "Estado";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Pendiente", "Aprobada", "Rechazada" });
            cboEstado.Location = new Point(268, -84);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(264, 23);
            cboEstado.TabIndex = 20;
            // 
            // lbl4
            // 
            lbl4.Location = new Point(556, -108);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(260, 22);
            lbl4.TabIndex = 21;
            lbl4.Text = "Desde";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(556, -84);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(264, 23);
            dtpDesde.TabIndex = 22;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(794, 776);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 34);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRechazar
            // 
            btnRechazar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRechazar.Location = new Point(674, 776);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(110, 34);
            btnRechazar.TabIndex = 32;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            // 
            // btnAprobar
            // 
            btnAprobar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAprobar.Location = new Point(554, 776);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(110, 34);
            btnAprobar.TabIndex = 33;
            btnAprobar.Text = "Aprobar";
            btnAprobar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(260, 22);
            label1.TabIndex = 34;
            label1.Text = "Área";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 23);
            comboBox1.TabIndex = 35;
            // 
            // label2
            // 
            label2.Location = new Point(309, 18);
            label2.Name = "label2";
            label2.Size = new Size(260, 22);
            label2.TabIndex = 36;
            label2.Text = "Estado";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Pendiente", "Aprobada", "Rechazada" });
            comboBox2.Location = new Point(309, 42);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(264, 23);
            comboBox2.TabIndex = 37;
            // 
            // label3
            // 
            label3.Location = new Point(597, 18);
            label3.Name = "label3";
            label3.Size = new Size(260, 22);
            label3.TabIndex = 38;
            label3.Text = "Desde";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(597, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 23);
            dateTimePicker1.TabIndex = 39;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(21, 90);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(130, 32);
            btnBuscar.TabIndex = 40;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lbl7
            // 
            lbl7.Location = new Point(21, 140);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(840, 22);
            lbl7.TabIndex = 41;
            lbl7.Text = "Solicitudes del área";
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.AllowUserToAddRows = false;
            dgvSolicitudes.AllowUserToDeleteRows = false;
            dgvSolicitudes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSolicitudes.BackgroundColor = SystemColors.Window;
            dgvSolicitudes.ColumnHeadersHeight = 32;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { dgvSolicitudesCol0, dgvSolicitudesCol1, dgvSolicitudesCol2, dgvSolicitudesCol3, dgvSolicitudesCol4 });
            dgvSolicitudes.Location = new Point(21, 166);
            dgvSolicitudes.MultiSelect = false;
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudes.Size = new Size(840, 132);
            dgvSolicitudes.TabIndex = 42;
            // 
            // dgvSolicitudesCol0
            // 
            dgvSolicitudesCol0.HeaderText = "N.º";
            dgvSolicitudesCol0.Name = "dgvSolicitudesCol0";
            dgvSolicitudesCol0.ReadOnly = true;
            // 
            // dgvSolicitudesCol1
            // 
            dgvSolicitudesCol1.HeaderText = "Fecha";
            dgvSolicitudesCol1.Name = "dgvSolicitudesCol1";
            dgvSolicitudesCol1.ReadOnly = true;
            // 
            // dgvSolicitudesCol2
            // 
            dgvSolicitudesCol2.HeaderText = "Empleado";
            dgvSolicitudesCol2.Name = "dgvSolicitudesCol2";
            dgvSolicitudesCol2.ReadOnly = true;
            // 
            // dgvSolicitudesCol3
            // 
            dgvSolicitudesCol3.HeaderText = "Área";
            dgvSolicitudesCol3.Name = "dgvSolicitudesCol3";
            dgvSolicitudesCol3.ReadOnly = true;
            // 
            // dgvSolicitudesCol4
            // 
            dgvSolicitudesCol4.HeaderText = "Estado";
            dgvSolicitudesCol4.Name = "dgvSolicitudesCol4";
            dgvSolicitudesCol4.ReadOnly = true;
            // 
            // btnVerSolicitud
            // 
            btnVerSolicitud.Location = new Point(21, 310);
            btnVerSolicitud.Name = "btnVerSolicitud";
            btnVerSolicitud.Size = new Size(130, 32);
            btnVerSolicitud.TabIndex = 43;
            btnVerSolicitud.Text = "Ver solicitud";
            btnVerSolicitud.UseVisualStyleBackColor = true;
            // 
            // lbl10
            // 
            lbl10.Location = new Point(21, 360);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(840, 22);
            lbl10.TabIndex = 44;
            lbl10.Text = "Detalle de la solicitud seleccionada";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = SystemColors.Window;
            dgvDetalle.ColumnHeadersHeight = 32;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { dgvDetalleCol0, dgvDetalleCol1, dgvDetalleCol2 });
            dgvDetalle.Location = new Point(21, 386);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(840, 132);
            dgvDetalle.TabIndex = 45;
            // 
            // dgvDetalleCol0
            // 
            dgvDetalleCol0.HeaderText = "Material";
            dgvDetalleCol0.Name = "dgvDetalleCol0";
            dgvDetalleCol0.ReadOnly = true;
            // 
            // dgvDetalleCol1
            // 
            dgvDetalleCol1.HeaderText = "Cantidad";
            dgvDetalleCol1.Name = "dgvDetalleCol1";
            dgvDetalleCol1.ReadOnly = true;
            // 
            // dgvDetalleCol2
            // 
            dgvDetalleCol2.HeaderText = "Unidad";
            dgvDetalleCol2.Name = "dgvDetalleCol2";
            dgvDetalleCol2.ReadOnly = true;
            // 
            // lbl12
            // 
            lbl12.Location = new Point(21, 530);
            lbl12.Name = "lbl12";
            lbl12.Size = new Size(840, 22);
            lbl12.TabIndex = 46;
            lbl12.Text = "Observaciones / motivo del rechazo";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(21, 554);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(840, 66);
            txtObservaciones.TabIndex = 47;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(751, 640);
            button1.Name = "button1";
            button1.Size = new Size(110, 34);
            button1.TabIndex = 48;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(631, 640);
            button2.Name = "button2";
            button2.Size = new Size(110, 34);
            button2.TabIndex = 49;
            button2.Text = "Rechazar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(511, 640);
            button3.Name = "button3";
            button3.Size = new Size(110, 34);
            button3.TabIndex = 50;
            button3.Text = "Aprobar";
            button3.UseVisualStyleBackColor = true;
            // 
            // AprobacionSolicitudesForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 702);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnBuscar);
            Controls.Add(lbl7);
            Controls.Add(dgvSolicitudes);
            Controls.Add(btnVerSolicitud);
            Controls.Add(lbl10);
            Controls.Add(dgvDetalle);
            Controls.Add(lbl12);
            Controls.Add(txtObservaciones);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(lbl0);
            Controls.Add(cboArea);
            Controls.Add(lbl2);
            Controls.Add(cboEstado);
            Controls.Add(lbl4);
            Controls.Add(dtpDesde);
            Controls.Add(btnCancelar);
            Controls.Add(btnRechazar);
            Controls.Add(btnAprobar);
            Name = "AprobacionSolicitudesForm1";
            Text = "AprobacionSolicitudesForm1";
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl0;
        private ComboBox cboArea;
        private Label lbl2;
        private ComboBox cboEstado;
        private Label lbl4;
        private DateTimePicker dtpDesde;
        private Button btnCancelar;
        private Button btnRechazar;
        private Button btnAprobar;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button btnBuscar;
        private Label lbl7;
        private DataGridView dgvSolicitudes;
        private DataGridViewTextBoxColumn dgvSolicitudesCol0;
        private DataGridViewTextBoxColumn dgvSolicitudesCol1;
        private DataGridViewTextBoxColumn dgvSolicitudesCol2;
        private DataGridViewTextBoxColumn dgvSolicitudesCol3;
        private DataGridViewTextBoxColumn dgvSolicitudesCol4;
        private Button btnVerSolicitud;
        private Label lbl10;
        private DataGridView dgvDetalle;
        private DataGridViewTextBoxColumn dgvDetalleCol0;
        private DataGridViewTextBoxColumn dgvDetalleCol1;
        private DataGridViewTextBoxColumn dgvDetalleCol2;
        private Label lbl12;
        private TextBox txtObservaciones;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}