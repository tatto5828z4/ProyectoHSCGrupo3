namespace CapaVistaHoteleria
{
    partial class frmHabitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHabitacion));
            this.dgvHabitacion = new System.Windows.Forms.DataGridView();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoCama = new System.Windows.Forms.ComboBox();
            this.txtIdTipoCama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.txtIdTipoHabitacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdHabitacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHabitacion
            // 
            this.dgvHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitacion.Location = new System.Drawing.Point(439, 142);
            this.dgvHabitacion.Name = "dgvHabitacion";
            this.dgvHabitacion.RowHeadersWidth = 47;
            this.dgvHabitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitacion.Size = new System.Drawing.Size(670, 272);
            this.dgvHabitacion.TabIndex = 30;
            this.dgvHabitacion.SelectionChanged += new System.EventHandler(this.dgvHabitacion_SelectionChanged);
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(88, 447);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 29;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            this.rbtInactivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtInactivo_MouseClick);
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(88, 424);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 28;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            this.rbtActivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtActivo_MouseClick);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(157, 433);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(46, 20);
            this.txtEstatus.TabIndex = 27;
            this.txtEstatus.Tag = "estatus";
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Estatus";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(82, 359);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 25;
            this.txtPrecio.Tag = "precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Precio";
            // 
            // cbxTipoCama
            // 
            this.cbxTipoCama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCama.FormattingEnabled = true;
            this.cbxTipoCama.Location = new System.Drawing.Point(82, 297);
            this.cbxTipoCama.Name = "cbxTipoCama";
            this.cbxTipoCama.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoCama.TabIndex = 23;
            this.cbxTipoCama.SelectedIndexChanged += new System.EventHandler(this.cbxTipoCama_SelectedIndexChanged);
            // 
            // txtIdTipoCama
            // 
            this.txtIdTipoCama.Location = new System.Drawing.Point(219, 297);
            this.txtIdTipoCama.Name = "txtIdTipoCama";
            this.txtIdTipoCama.Size = new System.Drawing.Size(46, 20);
            this.txtIdTipoCama.TabIndex = 22;
            this.txtIdTipoCama.Tag = "idTipoCama";
            this.txtIdTipoCama.TextChanged += new System.EventHandler(this.txtIdTipoCama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tipo Cama";
            // 
            // cbxTipoHabitacion
            // 
            this.cbxTipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoHabitacion.FormattingEnabled = true;
            this.cbxTipoHabitacion.Location = new System.Drawing.Point(82, 225);
            this.cbxTipoHabitacion.Name = "cbxTipoHabitacion";
            this.cbxTipoHabitacion.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoHabitacion.TabIndex = 20;
            this.cbxTipoHabitacion.SelectedIndexChanged += new System.EventHandler(this.cbxTipoHabitacion_SelectedIndexChanged);
            // 
            // txtIdTipoHabitacion
            // 
            this.txtIdTipoHabitacion.Location = new System.Drawing.Point(219, 225);
            this.txtIdTipoHabitacion.Name = "txtIdTipoHabitacion";
            this.txtIdTipoHabitacion.Size = new System.Drawing.Size(46, 20);
            this.txtIdTipoHabitacion.TabIndex = 19;
            this.txtIdTipoHabitacion.Tag = "idTipoHabitacion";
            this.txtIdTipoHabitacion.TextChanged += new System.EventHandler(this.txtIdTipoHabitacion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo Habitacion";
            // 
            // txtIdHabitacion
            // 
            this.txtIdHabitacion.Location = new System.Drawing.Point(82, 156);
            this.txtIdHabitacion.Name = "txtIdHabitacion";
            this.txtIdHabitacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdHabitacion.TabIndex = 17;
            this.txtIdHabitacion.Tag = "idHabitacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id Habitación";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(2, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 31;
            // 
            // frmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 536);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvHabitacion);
            this.Controls.Add(this.rbtInactivo);
            this.Controls.Add(this.rbtActivo);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTipoCama);
            this.Controls.Add(this.txtIdTipoCama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTipoHabitacion);
            this.Controls.Add(this.txtIdTipoHabitacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdHabitacion);
            this.Controls.Add(this.label1);
            this.Name = "frmHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1007 - Matenimiento Habitación";
            this.Load += new System.EventHandler(this.frmHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHabitacion;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoCama;
        private System.Windows.Forms.TextBox txtIdTipoCama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipoHabitacion;
        private System.Windows.Forms.TextBox txtIdTipoHabitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdHabitacion;
        private System.Windows.Forms.Label label1;
        private DLL.nav.navegador navegador1;
    }
}