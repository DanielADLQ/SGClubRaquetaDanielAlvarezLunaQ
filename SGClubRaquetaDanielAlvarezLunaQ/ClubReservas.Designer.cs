
namespace SGClubRaquetaDanielAlvarezLunaQ
{
    partial class ClubReservas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtxtCCC = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIdPista = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.picPistaSelec = new System.Windows.Forms.PictureBox();
            this.nudMinuto = new System.Windows.Forms.NumericUpDown();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboPistas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dgvReservasSocio = new System.Windows.Forms.DataGridView();
            this.idReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubraquetaDataSet1 = new SGClubRaquetaDanielAlvarezLunaQ.clubraquetaDataSet();
            this.cboSocios = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.Label();
            this.pistasTableAdapter1 = new SGClubRaquetaDanielAlvarezLunaQ.clubraquetaDataSetTableAdapters.pistasTableAdapter();
            this.reservasTableAdapter1 = new SGClubRaquetaDanielAlvarezLunaQ.clubraquetaDataSetTableAdapters.reservasTableAdapter();
            this.sociosTableAdapter1 = new SGClubRaquetaDanielAlvarezLunaQ.clubraquetaDataSetTableAdapters.sociosTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPistaSelec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elige al socio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "DNI socio:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mtxtCCC);
            this.panel1.Controls.Add(this.mtxtTelefono);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 110);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mtxtCCC
            // 
            this.mtxtCCC.Location = new System.Drawing.Point(438, 43);
            this.mtxtCCC.Mask = "ES99-9999-9999-9999-9999-9999";
            this.mtxtCCC.Name = "mtxtCCC";
            this.mtxtCCC.ReadOnly = true;
            this.mtxtCCC.Size = new System.Drawing.Size(323, 22);
            this.mtxtCCC.TabIndex = 20;
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Location = new System.Drawing.Point(107, 78);
            this.mtxtTelefono.Mask = "999-999-999";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.ReadOnly = true;
            this.mtxtTelefono.Size = new System.Drawing.Size(152, 22);
            this.mtxtTelefono.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(438, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(323, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(107, 45);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(236, 22);
            this.txtDireccion.TabIndex = 17;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(438, 11);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(323, 22);
            this.txtApellidos.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(236, 22);
            this.txtNombre.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "CCC:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtIdPista);
            this.panel2.Controls.Add(this.btnReservar);
            this.panel2.Controls.Add(this.picPistaSelec);
            this.panel2.Controls.Add(this.nudMinuto);
            this.panel2.Controls.Add(this.nudHora);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.cboPistas);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 188);
            this.panel2.TabIndex = 7;
            // 
            // txtIdPista
            // 
            this.txtIdPista.AutoSize = true;
            this.txtIdPista.Location = new System.Drawing.Point(376, 23);
            this.txtIdPista.Name = "txtIdPista";
            this.txtIdPista.Size = new System.Drawing.Size(54, 17);
            this.txtIdPista.TabIndex = 21;
            this.txtIdPista.Text = "label14";
            this.txtIdPista.Visible = false;
            // 
            // btnReservar
            // 
            this.btnReservar.Enabled = false;
            this.btnReservar.Location = new System.Drawing.Point(338, 122);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(99, 37);
            this.btnReservar.TabIndex = 2;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // picPistaSelec
            // 
            this.picPistaSelec.Location = new System.Drawing.Point(490, 20);
            this.picPistaSelec.Name = "picPistaSelec";
            this.picPistaSelec.Size = new System.Drawing.Size(253, 122);
            this.picPistaSelec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPistaSelec.TabIndex = 20;
            this.picPistaSelec.TabStop = false;
            // 
            // nudMinuto
            // 
            this.nudMinuto.Enabled = false;
            this.nudMinuto.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMinuto.Location = new System.Drawing.Point(193, 101);
            this.nudMinuto.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMinuto.Name = "nudMinuto";
            this.nudMinuto.Size = new System.Drawing.Size(53, 22);
            this.nudMinuto.TabIndex = 19;
            // 
            // nudHora
            // 
            this.nudHora.Enabled = false;
            this.nudHora.Location = new System.Drawing.Point(116, 101);
            this.nudHora.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.nudHora.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(53, 22);
            this.nudHora.TabIndex = 18;
            this.nudHora.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(175, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = ":";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(116, 61);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(130, 22);
            this.dtpFecha.TabIndex = 17;
            // 
            // cboPistas
            // 
            this.cboPistas.Enabled = false;
            this.cboPistas.FormattingEnabled = true;
            this.cboPistas.Location = new System.Drawing.Point(116, 20);
            this.cboPistas.Name = "cboPistas";
            this.cboPistas.Size = new System.Drawing.Size(227, 24);
            this.cboPistas.TabIndex = 16;
            this.cboPistas.SelectedIndexChanged += new System.EventHandler(this.cboPistas_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Duracion: 1h 30 minutos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hora inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Pista:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnPagar);
            this.panel3.Controls.Add(this.dgvReservasSocio);
            this.panel3.Location = new System.Drawing.Point(12, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 211);
            this.panel3.TabIndex = 8;
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(338, 162);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(99, 37);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // dgvReservasSocio
            // 
            this.dgvReservasSocio.AutoGenerateColumns = false;
            this.dgvReservasSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasSocio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReservaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.pistaDataGridViewTextBoxColumn,
            this.socioDataGridViewTextBoxColumn,
            this.pagadoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dgvReservasSocio.DataSource = this.reservasBindingSource;
            this.dgvReservasSocio.Location = new System.Drawing.Point(19, 12);
            this.dgvReservasSocio.MultiSelect = false;
            this.dgvReservasSocio.Name = "dgvReservasSocio";
            this.dgvReservasSocio.ReadOnly = true;
            this.dgvReservasSocio.RowHeadersWidth = 51;
            this.dgvReservasSocio.RowTemplate.Height = 24;
            this.dgvReservasSocio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservasSocio.Size = new System.Drawing.Size(742, 144);
            this.dgvReservasSocio.TabIndex = 0;
            // 
            // idReservaDataGridViewTextBoxColumn
            // 
            this.idReservaDataGridViewTextBoxColumn.DataPropertyName = "idReserva";
            this.idReservaDataGridViewTextBoxColumn.HeaderText = "idReserva";
            this.idReservaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idReservaDataGridViewTextBoxColumn.Name = "idReservaDataGridViewTextBoxColumn";
            this.idReservaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idReservaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pistaDataGridViewTextBoxColumn
            // 
            this.pistaDataGridViewTextBoxColumn.DataPropertyName = "pista";
            this.pistaDataGridViewTextBoxColumn.HeaderText = "pista";
            this.pistaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pistaDataGridViewTextBoxColumn.Name = "pistaDataGridViewTextBoxColumn";
            this.pistaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pistaDataGridViewTextBoxColumn.Width = 125;
            // 
            // socioDataGridViewTextBoxColumn
            // 
            this.socioDataGridViewTextBoxColumn.DataPropertyName = "socio";
            this.socioDataGridViewTextBoxColumn.HeaderText = "socio";
            this.socioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.socioDataGridViewTextBoxColumn.Name = "socioDataGridViewTextBoxColumn";
            this.socioDataGridViewTextBoxColumn.ReadOnly = true;
            this.socioDataGridViewTextBoxColumn.Width = 125;
            // 
            // pagadoDataGridViewTextBoxColumn
            // 
            this.pagadoDataGridViewTextBoxColumn.DataPropertyName = "pagado";
            this.pagadoDataGridViewTextBoxColumn.HeaderText = "pagado";
            this.pagadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pagadoDataGridViewTextBoxColumn.Name = "pagadoDataGridViewTextBoxColumn";
            this.pagadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "reservas";
            this.reservasBindingSource.DataSource = this.clubraquetaDataSet1;
            // 
            // clubraquetaDataSet1
            // 
            this.clubraquetaDataSet1.DataSetName = "clubraquetaDataSet";
            this.clubraquetaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboSocios
            // 
            this.cboSocios.FormattingEnabled = true;
            this.cboSocios.Location = new System.Drawing.Point(119, 15);
            this.cboSocios.Name = "cboSocios";
            this.cboSocios.Size = new System.Drawing.Size(210, 24);
            this.cboSocios.TabIndex = 9;
            this.cboSocios.SelectedIndexChanged += new System.EventHandler(this.cboSocios_SelectedIndexChanged);
            // 
            // txtDni
            // 
            this.txtDni.AutoSize = true;
            this.txtDni.Location = new System.Drawing.Point(431, 18);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(16, 17);
            this.txtDni.TabIndex = 10;
            this.txtDni.Text = "0";
            // 
            // pistasTableAdapter1
            // 
            this.pistasTableAdapter1.ClearBeforeFill = true;
            // 
            // reservasTableAdapter1
            // 
            this.reservasTableAdapter1.ClearBeforeFill = true;
            // 
            // sociosTableAdapter1
            // 
            this.sociosTableAdapter1.ClearBeforeFill = true;
            // 
            // ClubReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.cboSocios);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClubReservas";
            this.Text = "ClubReservas";
            this.Load += new System.EventHandler(this.ClubReservas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPistaSelec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtxtCCC;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudHora;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboPistas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picPistaSelec;
        private System.Windows.Forms.NumericUpDown nudMinuto;
        private System.Windows.Forms.DataGridView dgvReservasSocio;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.ComboBox cboSocios;
        private System.Windows.Forms.Label txtDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private clubraquetaDataSet clubraquetaDataSet1;
        private clubraquetaDataSetTableAdapters.pistasTableAdapter pistasTableAdapter1;
        private clubraquetaDataSetTableAdapters.reservasTableAdapter reservasTableAdapter1;
        private clubraquetaDataSetTableAdapters.sociosTableAdapter sociosTableAdapter1;
        private System.Windows.Forms.Label txtIdPista;
    }
}