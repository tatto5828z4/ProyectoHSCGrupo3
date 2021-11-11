namespace CapaVistaHoteleria
{
    partial class frmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresa));
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNitEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(438, 155);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.RowHeadersWidth = 47;
            this.dgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresa.Size = new System.Drawing.Size(669, 298);
            this.dgvEmpresa.TabIndex = 30;
            this.dgvEmpresa.SelectionChanged += new System.EventHandler(this.dgvEmpresa_SelectionChanged);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(213, 469);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(63, 20);
            this.txtEstatus.TabIndex = 29;
            this.txtEstatus.Tag = "estatus";
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(134, 492);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 28;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            this.rbtInactivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtInactivo_MouseClick);
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(134, 469);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 27;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            this.rbtActivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtActivo_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Estatus";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(120, 418);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 25;
            this.txtTelefono.Tag = "telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Teléfono Empresa";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(120, 352);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 23;
            this.txtDireccion.Tag = "direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Direccion Empresa";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 285);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.Tag = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre Empresa";
            // 
            // txtNitEmpresa
            // 
            this.txtNitEmpresa.Location = new System.Drawing.Point(120, 217);
            this.txtNitEmpresa.Name = "txtNitEmpresa";
            this.txtNitEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtNitEmpresa.TabIndex = 19;
            this.txtNitEmpresa.Tag = "nit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "NIT Empresa";
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Location = new System.Drawing.Point(120, 151);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmpresa.TabIndex = 17;
            this.txtIdEmpresa.Tag = "idEmpresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Empresa";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(2, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 31;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 536);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.rbtInactivo);
            this.Controls.Add(this.rbtActivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNitEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdEmpresa);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1002 - Mantenimiento Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNitEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.Label label1;
        private DLL.nav.navegador navegador1;
    }
}