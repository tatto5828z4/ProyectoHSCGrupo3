namespace CapaVistaHoteleria
{
    partial class frmSalon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalon));
            this.dgvSalon = new System.Windows.Forms.DataGridView();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdSalon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalon
            // 
            this.dgvSalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalon.Location = new System.Drawing.Point(487, 147);
            this.dgvSalon.Name = "dgvSalon";
            this.dgvSalon.RowHeadersWidth = 47;
            this.dgvSalon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalon.Size = new System.Drawing.Size(601, 240);
            this.dgvSalon.TabIndex = 18;
            this.dgvSalon.SelectionChanged += new System.EventHandler(this.dgvSalon_SelectionChanged);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(215, 358);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(54, 20);
            this.txtEstatus.TabIndex = 17;
            this.txtEstatus.Tag = "estatus";
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(137, 370);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 16;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            this.rbtInactivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtInactivo_MouseClick);
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(137, 347);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 15;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            this.rbtActivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtActivo_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Estatus";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 271);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.Tag = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre Salón";
            // 
            // txtIdSalon
            // 
            this.txtIdSalon.Location = new System.Drawing.Point(123, 191);
            this.txtIdSalon.Name = "txtIdSalon";
            this.txtIdSalon.Size = new System.Drawing.Size(100, 20);
            this.txtIdSalon.TabIndex = 11;
            this.txtIdSalon.Tag = "idSalon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Salón";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(1, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 19;
            // 
            // frmSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 536);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvSalon);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.rbtInactivo);
            this.Controls.Add(this.rbtActivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdSalon);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmSalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1009 - Mantenimiento Salón";
            this.Load += new System.EventHandler(this.frmSalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalon;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdSalon;
        private System.Windows.Forms.Label label1;
        private DLL.nav.navegador navegador1;
    }
}