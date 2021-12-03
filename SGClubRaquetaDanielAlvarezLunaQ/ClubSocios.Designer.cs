
namespace SGClubRaquetaDanielAlvarezLunaQ
{
    partial class ClubSocios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCrearSoc = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCCC = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtDniNuevoSoc = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDniSelec = new System.Windows.Forms.Label();
            this.btnEliminarSoc = new System.Windows.Forms.Button();
            this.btnModSoc = new System.Windows.Forms.Button();
            this.cboListaDni = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CCC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Apellidos:";
            // 
            // btnCrearSoc
            // 
            this.btnCrearSoc.BackColor = System.Drawing.Color.Lime;
            this.btnCrearSoc.Location = new System.Drawing.Point(313, 197);
            this.btnCrearSoc.Name = "btnCrearSoc";
            this.btnCrearSoc.Size = new System.Drawing.Size(142, 49);
            this.btnCrearSoc.TabIndex = 6;
            this.btnCrearSoc.Text = "CREAR SOCIO";
            this.btnCrearSoc.UseVisualStyleBackColor = false;
            this.btnCrearSoc.Click += new System.EventHandler(this.btnCrearSoc_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(94, 102);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(226, 22);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(434, 62);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(304, 22);
            this.txtApellidos.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(434, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Location = new System.Drawing.Point(94, 140);
            this.mtxtTelefono.Mask = "999999999";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(110, 22);
            this.mtxtTelefono.TabIndex = 11;
            // 
            // mtxtCCC
            // 
            this.mtxtCCC.Location = new System.Drawing.Point(434, 102);
            this.mtxtCCC.Mask = "ES99-9999-9999-9999-9999-9999";
            this.mtxtCCC.Name = "mtxtCCC";
            this.mtxtCCC.Size = new System.Drawing.Size(304, 22);
            this.mtxtCCC.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "DNI nuevo socio:";
            // 
            // mtxtDniNuevoSoc
            // 
            this.mtxtDniNuevoSoc.Location = new System.Drawing.Point(172, 18);
            this.mtxtDniNuevoSoc.Mask = "99999999-L";
            this.mtxtDniNuevoSoc.Name = "mtxtDniNuevoSoc";
            this.mtxtDniNuevoSoc.Size = new System.Drawing.Size(129, 22);
            this.mtxtDniNuevoSoc.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDniSelec);
            this.panel1.Controls.Add(this.btnEliminarSoc);
            this.panel1.Controls.Add(this.btnModSoc);
            this.panel1.Controls.Add(this.cboListaDni);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.mtxtDniNuevoSoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mtxtCCC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mtxtTelefono);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.btnCrearSoc);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 264);
            this.panel1.TabIndex = 15;
            // 
            // txtDniSelec
            // 
            this.txtDniSelec.AutoSize = true;
            this.txtDniSelec.Location = new System.Drawing.Point(625, 21);
            this.txtDniSelec.Name = "txtDniSelec";
            this.txtDniSelec.Size = new System.Drawing.Size(21, 17);
            this.txtDniSelec.TabIndex = 19;
            this.txtDniSelec.Text = "-1";
            // 
            // btnEliminarSoc
            // 
            this.btnEliminarSoc.BackColor = System.Drawing.Color.Red;
            this.btnEliminarSoc.Location = new System.Drawing.Point(548, 197);
            this.btnEliminarSoc.Name = "btnEliminarSoc";
            this.btnEliminarSoc.Size = new System.Drawing.Size(146, 49);
            this.btnEliminarSoc.TabIndex = 18;
            this.btnEliminarSoc.Text = "ELIMINAR SOCIO";
            this.btnEliminarSoc.UseVisualStyleBackColor = false;
            this.btnEliminarSoc.Click += new System.EventHandler(this.btnEliminarSoc_Click);
            // 
            // btnModSoc
            // 
            this.btnModSoc.BackColor = System.Drawing.Color.Aqua;
            this.btnModSoc.Location = new System.Drawing.Point(81, 197);
            this.btnModSoc.Name = "btnModSoc";
            this.btnModSoc.Size = new System.Drawing.Size(147, 49);
            this.btnModSoc.TabIndex = 17;
            this.btnModSoc.Text = "MODIFICAR SOCIO";
            this.btnModSoc.UseVisualStyleBackColor = false;
            this.btnModSoc.Click += new System.EventHandler(this.btnModSoc_Click);
            // 
            // cboListaDni
            // 
            this.cboListaDni.FormattingEnabled = true;
            this.cboListaDni.Location = new System.Drawing.Point(461, 18);
            this.cboListaDni.Name = "cboListaDni";
            this.cboListaDni.Size = new System.Drawing.Size(139, 24);
            this.cboListaDni.TabIndex = 16;
            this.cboListaDni.SelectedIndexChanged += new System.EventHandler(this.cboListaDni_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "DNI modificar socio:";
            // 
            // dgvSocios
            // 
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Location = new System.Drawing.Point(23, 372);
            this.dgvSocios.MultiSelect = false;
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.ReadOnly = true;
            this.dgvSocios.RowHeadersWidth = 51;
            this.dgvSocios.RowTemplate.Height = 24;
            this.dgvSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocios.Size = new System.Drawing.Size(754, 314);
            this.dgvSocios.TabIndex = 19;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(320, 308);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(169, 47);
            this.btnMostrar.TabIndex = 20;
            this.btnMostrar.Text = "MOSTRAR TODOS";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // ClubSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 708);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvSocios);
            this.Controls.Add(this.panel1);
            this.Name = "ClubSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClubSocios";
            this.Load += new System.EventHandler(this.ClubSocios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCrearSoc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
        private System.Windows.Forms.MaskedTextBox mtxtCCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtDniNuevoSoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarSoc;
        private System.Windows.Forms.Button btnModSoc;
        private System.Windows.Forms.ComboBox cboListaDni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.Label txtDniSelec;
        private System.Windows.Forms.Button btnMostrar;
    }
}