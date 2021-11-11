namespace CapaVistaHoteleria
{
    partial class frmTipoHabitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoHabitacion));
            this.dgvTipoHabitacion = new System.Windows.Forms.DataGridView();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTipoCama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoHabitacion
            // 
            this.dgvTipoHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoHabitacion.Location = new System.Drawing.Point(508, 171);
            this.dgvTipoHabitacion.Name = "dgvTipoHabitacion";
            this.dgvTipoHabitacion.RowHeadersWidth = 47;
            this.dgvTipoHabitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoHabitacion.Size = new System.Drawing.Size(610, 270);
            this.dgvTipoHabitacion.TabIndex = 18;
            this.dgvTipoHabitacion.SelectionChanged += new System.EventHandler(this.dgvTipoHabitacion_SelectionChanged);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(214, 377);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(51, 20);
            this.txtEstatus.TabIndex = 17;
            this.txtEstatus.Tag = "estatus";
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(126, 400);
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
            this.rbtActivo.Location = new System.Drawing.Point(126, 377);
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
            this.label3.Location = new System.Drawing.Point(112, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Estatus ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 299);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Tag = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre Tipo Habitación";
            // 
            // txtIdTipoCama
            // 
            this.txtIdTipoCama.Location = new System.Drawing.Point(115, 221);
            this.txtIdTipoCama.Name = "txtIdTipoCama";
            this.txtIdTipoCama.Size = new System.Drawing.Size(100, 20);
            this.txtIdTipoCama.TabIndex = 11;
            this.txtIdTipoCama.Tag = "idTipoHabitacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Tipo Habitación";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(2, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 19;
            // 
            // frmTipoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 536);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvTipoHabitacion);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.rbtInactivo);
            this.Controls.Add(this.rbtActivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdTipoCama);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1006 - Mantenimiento Tipo Habitacion";
            this.Load += new System.EventHandler(this.frmTipoHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoHabitacion;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTipoCama;
        private System.Windows.Forms.Label label1;
        private DLL.nav.navegador navegador1;
    }
}