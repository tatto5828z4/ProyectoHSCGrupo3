namespace CapaVistaHoteleria
{
    partial class frmTipoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoCliente));
            this.dgvTipoCliente = new System.Windows.Forms.DataGridView();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTipoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoCliente
            // 
            this.dgvTipoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCliente.Location = new System.Drawing.Point(464, 153);
            this.dgvTipoCliente.Name = "dgvTipoCliente";
            this.dgvTipoCliente.RowHeadersWidth = 47;
            this.dgvTipoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoCliente.Size = new System.Drawing.Size(651, 259);
            this.dgvTipoCliente.TabIndex = 18;
            this.dgvTipoCliente.SelectionChanged += new System.EventHandler(this.dgvTipoCliente_SelectionChanged);
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(97, 362);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 17;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            this.rbtInactivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtInactivo_MouseClick);
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(97, 339);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 16;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            this.rbtActivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(188, 350);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(48, 20);
            this.txtEstatus.TabIndex = 15;
            this.txtEstatus.Tag = "estatus";
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(95, 313);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(45, 13);
            this.lblEstatus.TabIndex = 14;
            this.lblEstatus.Text = "Estátus:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 269);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.Tag = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre Tipo Cliente";
            // 
            // txtIdTipoCliente
            // 
            this.txtIdTipoCliente.Location = new System.Drawing.Point(98, 196);
            this.txtIdTipoCliente.Name = "txtIdTipoCliente";
            this.txtIdTipoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdTipoCliente.TabIndex = 11;
            this.txtIdTipoCliente.Tag = "idTipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Tipo Cliente";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(2, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 19;
            // 
            // frmTipoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 536);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvTipoCliente);
            this.Controls.Add(this.rbtInactivo);
            this.Controls.Add(this.rbtActivo);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdTipoCliente);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmTipoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1004 - Mantenimiento Tipo Cliente";
            this.Load += new System.EventHandler(this.frmTipoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoCliente;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTipoCliente;
        private System.Windows.Forms.Label label1;
        private DLL.nav.navegador navegador1;
    }
}