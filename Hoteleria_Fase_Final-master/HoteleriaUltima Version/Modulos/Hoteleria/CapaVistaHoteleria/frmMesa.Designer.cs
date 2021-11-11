namespace CapaVistaHoteleria
{
    partial class frmMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesa));
            this.navegador1 = new DLL.nav.navegador();
            this.txtEstatus2 = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.pnlEstadoD = new System.Windows.Forms.Panel();
            this.rbtOcupada = new System.Windows.Forms.RadioButton();
            this.rbtDisponible = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.cbxSalon = new System.Windows.Forms.ComboBox();
            this.dgvMesa = new System.Windows.Forms.DataGridView();
            this.txtIdSalon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEstadoD.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).BeginInit();
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
            // txtEstatus2
            // 
            this.txtEstatus2.Location = new System.Drawing.Point(243, 478);
            this.txtEstatus2.Name = "txtEstatus2";
            this.txtEstatus2.Size = new System.Drawing.Size(54, 20);
            this.txtEstatus2.TabIndex = 36;
            this.txtEstatus2.Tag = "estadoDisponibilidad";
            this.txtEstatus2.TextChanged += new System.EventHandler(this.txtEstatus2_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(217, 376);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(54, 20);
            this.txtEstado.TabIndex = 34;
            this.txtEstado.Tag = "estado";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // pnlEstadoD
            // 
            this.pnlEstadoD.Controls.Add(this.rbtOcupada);
            this.pnlEstadoD.Controls.Add(this.rbtDisponible);
            this.pnlEstadoD.Controls.Add(this.label5);
            this.pnlEstadoD.Location = new System.Drawing.Point(109, 437);
            this.pnlEstadoD.Name = "pnlEstadoD";
            this.pnlEstadoD.Size = new System.Drawing.Size(128, 81);
            this.pnlEstadoD.TabIndex = 35;
            // 
            // rbtOcupada
            // 
            this.rbtOcupada.AutoSize = true;
            this.rbtOcupada.Location = new System.Drawing.Point(17, 50);
            this.rbtOcupada.Name = "rbtOcupada";
            this.rbtOcupada.Size = new System.Drawing.Size(69, 17);
            this.rbtOcupada.TabIndex = 25;
            this.rbtOcupada.TabStop = true;
            this.rbtOcupada.Text = "Ocupada";
            this.rbtOcupada.UseVisualStyleBackColor = true;
            this.rbtOcupada.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtOcupada_MouseClick);
            // 
            // rbtDisponible
            // 
            this.rbtDisponible.AutoSize = true;
            this.rbtDisponible.Location = new System.Drawing.Point(17, 30);
            this.rbtDisponible.Name = "rbtDisponible";
            this.rbtDisponible.Size = new System.Drawing.Size(74, 17);
            this.rbtDisponible.TabIndex = 25;
            this.rbtDisponible.TabStop = true;
            this.rbtDisponible.Text = "Disponible";
            this.rbtDisponible.UseVisualStyleBackColor = true;
            this.rbtDisponible.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtDisponible_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Estado Disponibilidad";
            // 
            // pnlEstado
            // 
            this.pnlEstado.Controls.Add(this.label4);
            this.pnlEstado.Controls.Add(this.rbtInactivo);
            this.pnlEstado.Controls.Add(this.rbtActivo);
            this.pnlEstado.Location = new System.Drawing.Point(109, 334);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(102, 81);
            this.pnlEstado.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Estado";
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(17, 54);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 22;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            this.rbtInactivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtInactivo_MouseClick);
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(17, 31);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 21;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            this.rbtActivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtActivo_MouseClick);
            // 
            // cbxSalon
            // 
            this.cbxSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSalon.FormattingEnabled = true;
            this.cbxSalon.Location = new System.Drawing.Point(109, 290);
            this.cbxSalon.Name = "cbxSalon";
            this.cbxSalon.Size = new System.Drawing.Size(121, 21);
            this.cbxSalon.TabIndex = 32;
            this.cbxSalon.SelectedIndexChanged += new System.EventHandler(this.cbxSalon_SelectedIndexChanged);
            this.cbxSalon.SelectedValueChanged += new System.EventHandler(this.cbxSalon_SelectedValueChanged);
            // 
            // dgvMesa
            // 
            this.dgvMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesa.Location = new System.Drawing.Point(477, 142);
            this.dgvMesa.Name = "dgvMesa";
            this.dgvMesa.RowHeadersWidth = 47;
            this.dgvMesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMesa.Size = new System.Drawing.Size(601, 240);
            this.dgvMesa.TabIndex = 31;
            this.dgvMesa.SelectionChanged += new System.EventHandler(this.dgvMesa_SelectionChanged);
            // 
            // txtIdSalon
            // 
            this.txtIdSalon.Location = new System.Drawing.Point(236, 291);
            this.txtIdSalon.Name = "txtIdSalon";
            this.txtIdSalon.Size = new System.Drawing.Size(54, 20);
            this.txtIdSalon.TabIndex = 30;
            this.txtIdSalon.Tag = "idSalon";
            this.txtIdSalon.TextChanged += new System.EventHandler(this.txtIdSalon_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Salón";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 232);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 28;
            this.txtNombre.Tag = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre Mesa";
            // 
            // txtIdMesa
            // 
            this.txtIdMesa.Location = new System.Drawing.Point(111, 165);
            this.txtIdMesa.Name = "txtIdMesa";
            this.txtIdMesa.Size = new System.Drawing.Size(100, 20);
            this.txtIdMesa.TabIndex = 26;
            this.txtIdMesa.Tag = "idMesa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID Mesa";
            // 
            // frmMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 536);
            this.Controls.Add(this.txtEstatus2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.pnlEstadoD);
            this.Controls.Add(this.pnlEstado);
            this.Controls.Add(this.cbxSalon);
            this.Controls.Add(this.dgvMesa);
            this.Controls.Add(this.txtIdSalon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdMesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "frmMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1010 - Mantenimiento Mesa";
            this.Load += new System.EventHandler(this.frmMesa_Load);
            this.pnlEstadoD.ResumeLayout(false);
            this.pnlEstadoD.PerformLayout();
            this.pnlEstado.ResumeLayout(false);
            this.pnlEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtEstatus2;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Panel pnlEstadoD;
        private System.Windows.Forms.RadioButton rbtOcupada;
        private System.Windows.Forms.RadioButton rbtDisponible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.ComboBox cbxSalon;
        private System.Windows.Forms.DataGridView dgvMesa;
        private System.Windows.Forms.TextBox txtIdSalon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMesa;
        private System.Windows.Forms.Label label1;
    }
}