namespace CapaVistaHoteleria
{
    partial class frmSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSucursal));
            this.navegador1 = new DLL.nav.navegador();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEmpresa = new System.Windows.Forms.ComboBox();
            this.dgvSucursal = new System.Windows.Forms.DataGridView();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(1, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(416, 241);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(57, 20);
            this.txtEstatus.TabIndex = 55;
            this.txtEstatus.Tag = "estatus";
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(333, 263);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 54;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            this.rbtInactivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtInactivo_MouseClick);
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(333, 240);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 53;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            this.rbtActivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtActivo_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Estado";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(319, 176);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPostal.TabIndex = 51;
            this.txtCodigoPostal.Tag = "codigoPostal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Código Postal";
            // 
            // cbxEmpresa
            // 
            this.cbxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpresa.FormattingEnabled = true;
            this.cbxEmpresa.Location = new System.Drawing.Point(73, 240);
            this.cbxEmpresa.Name = "cbxEmpresa";
            this.cbxEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cbxEmpresa.TabIndex = 49;
            this.cbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbxEmpresa_SelectedIndexChanged);
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursal.Location = new System.Drawing.Point(479, 157);
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.RowHeadersWidth = 47;
            this.dgvSucursal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSucursal.Size = new System.Drawing.Size(675, 298);
            this.dgvSucursal.TabIndex = 48;
            this.dgvSucursal.SelectionChanged += new System.EventHandler(this.dgvSucursal_SelectionChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(73, 443);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 47;
            this.txtTelefono.Tag = "telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Teléfono Sucursal";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(73, 377);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 45;
            this.txtDireccion.Tag = "direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Direccion Sucursal";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 310);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 43;
            this.txtNombre.Tag = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nombre Sucursal";
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Location = new System.Drawing.Point(222, 240);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(64, 20);
            this.txtIdEmpresa.TabIndex = 41;
            this.txtIdEmpresa.Tag = "idEmpresa";
            this.txtIdEmpresa.TextChanged += new System.EventHandler(this.txtIdEmpresa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Empresa";
            // 
            // txtIdSucursal
            // 
            this.txtIdSucursal.Location = new System.Drawing.Point(73, 176);
            this.txtIdSucursal.Name = "txtIdSucursal";
            this.txtIdSucursal.Size = new System.Drawing.Size(100, 20);
            this.txtIdSucursal.TabIndex = 39;
            this.txtIdSucursal.Tag = "idSucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID Sucursal";
            // 
            // frmSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 536);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.rbtInactivo);
            this.Controls.Add(this.rbtActivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxEmpresa);
            this.Controls.Add(this.dgvSucursal);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "frmSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1003 - Mantenimiento Sucursal";
            this.Load += new System.EventHandler(this.frmSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEmpresa;
        private System.Windows.Forms.DataGridView dgvSucursal;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdSucursal;
        private System.Windows.Forms.Label label1;
    }
}